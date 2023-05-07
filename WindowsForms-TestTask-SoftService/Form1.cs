using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WindowsForms_TestTask_SoftService.Interfaces;
using WindowsForms_TestTask_SoftService.Models;
using WindowsForms_TestTask_SoftService.View;

namespace WindowsForms_TestTask_SoftService
{
    public partial class Form1 : Form
    {
        private ICarRepository _carRepository;

        public Form1()
        {
            InitializeComponent();
            _carRepository = new CarRepository();
            timer1.Start();
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var cars = _carRepository.GetCars();
            dataGridView1.DataSource = cars;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            var cars = _carRepository.GetCars();
            foreach (var car in cars)
            {
                car.Speed = random.Next(0, 200) + random.NextDouble();
                _carRepository.UpdateCar(car);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                var row = dataGridView1.Rows[e.RowIndex];
                _carRepository.DeleteCar(Convert.ToInt32(row.Cells["ID"].Value));
            }
            if(dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "edit")
            {

                var row = dataGridView1.Rows[e.RowIndex];
                Car car = new Car
                {
                    ID = Convert.ToInt32(row.Cells["ID"].Value),
                    Number = Convert.ToString(row.Cells["Number"].Value),
                    Brand = Convert.ToString(row.Cells["Brand"].Value),
                    Color = Convert.ToString(row.Cells["Color"].Value),
                    Mileage = Convert.ToDouble(row.Cells["Mileage"].Value),
                    Speed = Convert.ToDouble(row.Cells["Speed"].Value)
                };
                EditForm editForm = new EditForm(car);
                editForm.Show();
                
            }
        }
    }
}
