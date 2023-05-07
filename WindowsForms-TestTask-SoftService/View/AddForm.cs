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
    public partial class AddForm : Form
    {
        private ICarRepository _carRepository;
        public AddForm()
        {
            InitializeComponent();
            _carRepository = new CarRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Number = AddForm_textBox1_Number.Text,
                Brand = AddForm_textBox1_Brand.Text,
                Color = AddForm_textBox1_Color.Text,
                Mileage = Convert.ToDouble(AddForm_textBox1_Mileage.Text),
                Speed = Convert.ToDouble(AddForm_textBox1_Speed.Text)
            };
            _carRepository.AddCar(car);
            this.Close();
        }
    }
}
