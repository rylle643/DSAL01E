using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACOTIN_POS_APPLICATION
{
    public partial class employee_registration : Form
    {
        string picpath;
        employee_dbconnection emp_db_connect = new employee_dbconnection();

        public employee_registration()
        {
            InitializeComponent();
        }
        private void cleartextboxes()
        {
            emp_idTxtBox.Clear();
            fnameTxtBox.Clear();
            mnameTxtBox.Clear();
            surnameTxtBox.Clear();
            sssTxtBox.Clear();
            tinTxtBox.Clear();
            philhealthTxtBox.Clear();
            pagibigTxtBox.Clear();
            heightTxtBox.Clear();
            weightTxtBox.Clear();
            current_yrsTxtBox.Clear();
            current_ho_noTxtBox.Clear();
            currentSub_noTxtBox.Clear();
            current_phaseTxtBox.Clear();
            cuurent_streetTxtBox.Clear();
            current_barangayTxtBox.Clear();
            current_municipalityTxtBox.Clear();
            current_cityTxtBox.Clear();
            current_stateTxtBox.Clear();
            current_countryTxtBox.Clear();
            current_ZipTxtBox.Clear();
            elem_nameTxtBox.Clear();
            elem_addressTxtBox.Clear();
            elem_awardTxtBox.Clear();
            junior_nameTxtBox.Clear();
            junior_addressTxtBox.Clear();
            junior_awardTxtBox.Clear();
            senior_nameTxtBox.Clear();
            senior_addressTxtBox.Clear();
            senior_awardTxtBox.Clear();
            senior_courseTxtBox.Clear();
            college_school_nameTxtBox.Clear();
            college_addressTxtBox.Clear();
            college_degreeTxtBox.Clear();
            college_awardTxtBox.Clear();
            othersTxtBox.Clear();
            positionTxtBox.Clear();
            employeeStatusTxtBox.Clear();
            departmentTxtBox.Clear();
            emp_num_dependentsTxtBox.Clear();
            picturepathTxtBox.Clear();

            comboBox1.SelectedIndex = 0; 
            comboBox2.SelectedIndex = 2; 
            comboBox3.SelectedIndex = 0;

            dateTimePicker6.Value = DateTime.Now;
            dateTimePicker5.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            string defaultImagePath = Path.Combine(Application.StartupPath, "Resources", "no-image-available-icon-vector.jpg");
            if (File.Exists(defaultImagePath))
            {
                picbox.Image = Image.FromFile(defaultImagePath);
            }
            else
            {
                picbox.Image = null;
            }

            emp_idTxtBox.Focus();
        }

        private void PopulateAllComboBoxes()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Select...");
            for (int age = 18; age <= 65; age++)
            {
                comboBox1.Items.Add(age.ToString());
            }
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            comboBox2.Items.Add("Select...");
            comboBox2.Items.Add("Male");
            comboBox2.Items.Add("Female");
            comboBox2.Items.Add("Other");
            comboBox2.SelectedIndex = 0; 

            comboBox3.Items.Clear();
            comboBox3.Items.Add("Select...");
            comboBox3.Items.Add("Single");
            comboBox3.Items.Add("Married");
            comboBox3.Items.Add("Divorced");
            comboBox3.Items.Add("Widowed");
            comboBox3.SelectedIndex = 0;
        }

        private void employee_registration_Load(object sender, EventArgs e)
        {
            try
            {


                PopulateAllComboBoxes();

                picturepathTxtBox.Hide();
                string defaultImagePath = Path.Combine(Application.StartupPath, "Resources", "no-image-available-icon-vector.jpg");
                if (File.Exists(defaultImagePath))
                {
                    picbox.Image = Image.FromFile(defaultImagePath);
                }

                emp_db_connect.employee_connString();
                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!"); 
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
                openFileDialog1.ShowDialog(); 

                picbox.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picturepathTxtBox.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                emp_db_connect.employee_connString();
                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtBox.Text + "'";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();

                // Check if employee exists
                if (emp_db_connect.employee_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Employee not found!");
                    return;
                }

                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];

                fnameTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][2].ToString();
                mnameTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][3].ToString();
                surnameTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][4].ToString();
                comboBox1.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][5].ToString();  
                comboBox2.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][6].ToString();  
                sssTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][7].ToString();
                tinTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][8].ToString();
                philhealthTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][9].ToString();
                pagibigTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][10].ToString();
                comboBox3.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][11].ToString();
                heightTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][12].ToString();
                weightTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][13].ToString();

                current_yrsTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][14].ToString();
                current_ho_noTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][15].ToString();
                currentSub_noTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][16].ToString();
                current_phaseTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][17].ToString();
                cuurent_streetTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][18].ToString();
                current_barangayTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][19].ToString();
                current_municipalityTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][20].ToString();
                current_cityTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][21].ToString();
                current_stateTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][22].ToString();
                current_countryTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][23].ToString();
                current_ZipTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][24].ToString();

                elem_nameTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][25].ToString();
                elem_addressTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][26].ToString();

                string elem_date = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][27].ToString();
                if (!string.IsNullOrEmpty(elem_date))
                {
                    dateTimePicker6.Value = Convert.ToDateTime(elem_date);
                }

                elem_awardTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][28].ToString();

                junior_nameTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][29].ToString();
                junior_addressTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][30].ToString();

                string junior_date = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][31].ToString();
                if (!string.IsNullOrEmpty(junior_date))
                {
                    dateTimePicker5.Value = Convert.ToDateTime(junior_date);
                }

                junior_awardTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][32].ToString();

                senior_nameTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][33].ToString();
                senior_addressTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][34].ToString();

                string senior_date = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][35].ToString();
                if (!string.IsNullOrEmpty(senior_date))
                {
                    dateTimePicker4.Value = Convert.ToDateTime(senior_date);
                }

                senior_awardTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][36].ToString();
                senior_courseTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][37].ToString();

                college_school_nameTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][38].ToString();
                college_addressTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][39].ToString();

                string college_date = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][40].ToString();
                if (!string.IsNullOrEmpty(college_date))
                {
                    dateTimePicker1.Value = Convert.ToDateTime(college_date);
                }

                college_awardTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][41].ToString();
                college_degreeTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][42].ToString();

                othersTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][43].ToString();
                positionTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][44].ToString();
                employeeStatusTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][45].ToString();

                string hired_date = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][46].ToString();
                if (!string.IsNullOrEmpty(hired_date))
                {
                    dateTimePicker2.Value = Convert.ToDateTime(hired_date);
                }

                departmentTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][47].ToString();
                emp_num_dependentsTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][48].ToString();

                picturepathTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][49].ToString();

                if (File.Exists(picturepathTxtBox.Text))
                {
                    picbox.Image = Image.FromFile(picturepathTxtBox.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                emp_db_connect.employee_connString();
                emp_db_connect.employee_sql = "INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, " +
                    "emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, emp_height, emp_weight, " +
                    "add_yrs_stay, add_house_no, add_sub_name, add_phase_no, add_street, add_barangay, add_municipality, " +
                    "add_city, add_state_province, add_country, add_zipcode, elem_name, elem_address, elem_yr_grad, " +
                    "elem_award, junior_high_name, junior_high_address, junior_high_yr_grad, junior_high_award, " +
                    "senior_high_name, senior_high_address, senior_high_yr_grad, senior_high_award, track, " +
                    "college_school_name, college_address, college_yr_grad, college_award, college_course, others, " +
                    "position, emp_work_status, emp_date_hired, emp_department, emp_no_of_dependents, picpath) " +
                    "VALUES ('" + emp_idTxtBox.Text + "', '" +
                    fnameTxtBox.Text + "', '" +
                    mnameTxtBox.Text + "', '" +
                    surnameTxtBox.Text + "', '" +
                    comboBox1.Text + "', '" +
                    comboBox2.Text + "', '" +
                    sssTxtBox.Text + "', '" +
                    tinTxtBox.Text + "', '" +
                    philhealthTxtBox.Text + "', '" +
                    pagibigTxtBox.Text + "', '" +
                    comboBox3.Text + "', '" +
                    heightTxtBox.Text + "', '" +
                    weightTxtBox.Text + "', '" +
                    current_yrsTxtBox.Text + "', '" +
                    current_ho_noTxtBox.Text + "', '" +
                    currentSub_noTxtBox.Text + "', '" +
                    current_phaseTxtBox.Text + "', '" +
                    cuurent_streetTxtBox.Text + "', '" +
                    current_barangayTxtBox.Text + "', '" +
                    current_municipalityTxtBox.Text + "', '" +
                    current_cityTxtBox.Text + "', '" +
                    current_stateTxtBox.Text + "', '" +
                    current_countryTxtBox.Text + "', '" +
                    current_ZipTxtBox.Text + "', '" +
                    elem_nameTxtBox.Text + "', '" +
                    elem_addressTxtBox.Text + "', '" +
                    dateTimePicker6.Value.ToString("yyyy-MM-dd") + "', '" +
                    elem_awardTxtBox.Text + "', '" +
                    junior_nameTxtBox.Text + "', '" +
                    junior_addressTxtBox.Text + "', '" +
                    dateTimePicker5.Value.ToString("yyyy-MM-dd") + "', '" +
                    junior_awardTxtBox.Text + "', '" +
                    senior_nameTxtBox.Text + "', '" +
                    senior_addressTxtBox.Text + "', '" +
                    dateTimePicker4.Value.ToString("yyyy-MM-dd") + "', '" +
                    senior_awardTxtBox.Text + "', '" +
                    senior_courseTxtBox.Text + "', '" +
                    college_school_nameTxtBox.Text + "', '" +
                    college_addressTxtBox.Text + "', '" +
                    dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" +
                    college_awardTxtBox.Text + "', '" +
                    college_degreeTxtBox.Text + "', '" +
                    othersTxtBox.Text + "', '" +
                    positionTxtBox.Text + "', '" +
                    employeeStatusTxtBox.Text + "', '" +
                    dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', '" +
                    departmentTxtBox.Text + "', '" +
                    emp_num_dependentsTxtBox.Text + "', '" +
                    picturepathTxtBox.Text + "')";

                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterInsert();

                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\nPlease contact your administrator!");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                emp_db_connect.employee_connString();
                emp_db_connect.employee_sql = "UPDATE pos_empRegTbl SET emp_fname = '" + fnameTxtBox.Text + "', " +
                    "emp_mname = '" + mnameTxtBox.Text + "', " +
                    "emp_surname = '" + surnameTxtBox.Text + "', " +
                    "emp_age = '" + comboBox1.Text + "', " +
                    "emp_gender = '" + comboBox2.Text + "', " +
                    "emp_sss_no = '" + sssTxtBox.Text + "', " +
                    "emp_tin_no = '" + tinTxtBox.Text + "', " +
                    "emp_philhealth_no = '" + philhealthTxtBox.Text + "', " +
                    "emp_pagibig_no = '" + pagibigTxtBox.Text + "', " +
                    "emp_status = '" + comboBox3.Text + "', " +
                    "emp_height = '" + heightTxtBox.Text + "', " +
                    "emp_weight = '" + weightTxtBox.Text + "', " +
                    "add_yrs_stay = '" + current_yrsTxtBox.Text + "', " +
                    "add_house_no = '" + current_ho_noTxtBox.Text + "', " +
                    "add_sub_name = '" + currentSub_noTxtBox.Text + "', " +
                    "add_phase_no = '" + current_phaseTxtBox.Text + "', " +
                    "add_street = '" + cuurent_streetTxtBox.Text + "', " +
                    "add_barangay = '" + current_barangayTxtBox.Text + "', " +
                    "add_municipality = '" + current_municipalityTxtBox.Text + "', " +
                    "add_city = '" + current_cityTxtBox.Text + "', " +
                    "add_state_province = '" + current_stateTxtBox.Text + "', " +
                    "add_country = '" + current_countryTxtBox.Text + "', " +
                    "add_zipcode = '" + current_ZipTxtBox.Text + "', " +
                    "elem_name = '" + elem_nameTxtBox.Text + "', " +
                    "elem_address = '" + elem_addressTxtBox.Text + "', " +
                    "elem_yr_grad = '" + dateTimePicker6.Value.ToString("yyyy-MM-dd") + "', " +
                    "elem_award = '" + elem_awardTxtBox.Text + "', " +
                    "junior_high_name = '" + junior_nameTxtBox.Text + "', " +
                    "junior_high_address = '" + junior_addressTxtBox.Text + "', " +
                    "junior_high_yr_grad = '" + dateTimePicker5.Value.ToString("yyyy-MM-dd") + "', " +
                    "junior_high_award = '" + junior_awardTxtBox.Text + "', " +
                    "senior_high_name = '" + senior_nameTxtBox.Text + "', " +
                    "senior_high_address = '" + senior_addressTxtBox.Text + "', " +
                    "senior_high_yr_grad = '" + dateTimePicker4.Value.ToString("yyyy-MM-dd") + "', " +
                    "senior_high_award = '" + senior_awardTxtBox.Text + "', " +
                    "track = '" + senior_courseTxtBox.Text + "', " +
                    "college_school_name = '" + college_school_nameTxtBox.Text + "', " +
                    "college_address = '" + college_addressTxtBox.Text + "', " +
                    "college_yr_grad = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', " +
                    "college_award = '" + college_awardTxtBox.Text + "', " +
                    "college_course = '" + college_degreeTxtBox.Text + "', " +
                    "others = '" + othersTxtBox.Text + "', " +
                    "position = '" + positionTxtBox.Text + "', " +
                    "emp_work_status = '" + employeeStatusTxtBox.Text + "', " +
                    "emp_date_hired = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', " +
                    "emp_department = '" + departmentTxtBox.Text + "', " +
                    "emp_no_of_dependents = '" + emp_num_dependentsTxtBox.Text + "', " +
                    "picpath = '" + picturepathTxtBox.Text + "' " +
                    "WHERE emp_id = '" + emp_idTxtBox.Text + "'";

                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterUpdate();

                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                emp_db_connect.employee_connString();
                emp_db_connect.employee_sql = "DELETE FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtBox.Text + "'";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterDelete();
                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
