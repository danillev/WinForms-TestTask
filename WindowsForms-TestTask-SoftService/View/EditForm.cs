using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_TestTask_SoftService.Interfaces;
using WindowsForms_TestTask_SoftService.Models;

namespace WindowsForms_TestTask_SoftService.View
{
    public partial class EditForm : Form
    {
        private ICarRepository _carRepository;

        public EditForm()
        {
            InitializeComponent();
            _carRepository = new CarRepository();
        }

        public EditForm(Car car)
        {

            InitializeComponent();
            _carRepository = new CarRepository();
            EditForm_textBox_id.Text = Convert.ToString(car.ID);
            EditForm_textBox_Number.Text = Convert.ToString(car.Number);
            EditForm_textBox_Brand.Text = Convert.ToString(car.Brand);
            EditForm_textBox_Color.Text = Convert.ToString(car.Color);
            EditForm_textBox_mileage.Text = Convert.ToString(car.Mileage);
            EditForm_textBox_speed.Text = Convert.ToString(car.Speed);
        }

        private void EditForm_Button_Edit_Click(object sender, EventArgs e)
        {
            Car car = new Car
            {
                ID = Convert.ToInt32(EditForm_textBox_id.Text),
                Number = EditForm_textBox_Number.Text,
                Brand = EditForm_textBox_Brand.Text,
                Color = EditForm_textBox_Color.Text,
                Mileage = Convert.ToDouble(EditForm_textBox_mileage.Text),
                Speed = Convert.ToDouble(EditForm_textBox_speed.Text),
            };
            _carRepository.UpdateCar(car);
            this.Close();
        }
    }
}
