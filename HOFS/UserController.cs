using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOFS
{
    public partial class UserController : Form
    {
       
       
        RealStateManager rsl = new RealStateManager();
        DataController DC = new DataController();
        public UserController()
        {
            InitializeComponent();
            CountryBox.DataSource = null;
            CountryBox.DataSource = System.Enum.GetValues(typeof(Countries));
            CategoryBox.SelectedIndex = 0;
            LegalFormBox.SelectedIndex = 0;

        }

        private void UserController_Load(object sender, EventArgs e)
        {

        }

        private void UserItemViewer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserItemViewer.SelectedIndex > -1)
            {
                saveChange.Enabled = true;
                
                int index = UserItemViewer.Items.IndexOf(UserItemViewer.SelectedItem);

                AEstate estate = rsl.GetAt(index);

                CategoryBox.Text = estate.GetCategory();
                TypeBox.Text = estate.GetTypeEstate();
                LegalFormBox.Text = estate.GetLegal();
                CountryBox.Text = estate.GetCountry();
                StreetTxtBox.Text = estate.GetStreet();
                CityTxtBox.Text = estate.GetCity();
                ZipCodeTxtBox.Text = estate.GetZipCode();
                pictureBox.Image = estate.GetImage();
                IdLb.Text = estate.GetId().ToString();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            
            Address address = new Address(CountryBox.Text, CityTxtBox.Text, StreetTxtBox.Text, ZipCodeTxtBox.Text);
         //   estate newestate = new estate(id ,CategoryBox.Text, TypeBox.Text, LegalFormBox.Text, address);
            rsl.AddItem( CategoryBox.Text, TypeBox.Text, LegalFormBox.Text, address,pictureBox.Image);

            AEstate estate = rsl.GetAt();
            


            UserItemViewer.Items.Add(estate.GetId()+"  "+ estate.GetCategory() + " "+ estate.GetTypeEstate() + " "+ estate.GetLegal() +
                " "+ estate.GetCountry() + " " + estate.GetCity() + " " + estate.GetStreet() + " " + estate.GetZipCode());
            //UserItemViewer.DataSource = list.ToString();

            ListViewItem lv = new ListViewItem(estate.GetId().ToString());
            lv.SubItems.Add(estate.GetCategory());
            lv.SubItems.Add(estate.GetTypeEstate());
            lv.SubItems.Add(estate.GetLegal());
            lv.SubItems.Add(estate.GetCountry());
            lv.SubItems.Add(estate.GetCity());
            lv.SubItems.Add(estate.GetStreet());
            lv.SubItems.Add(estate.GetZipCode());
            UserlistView.Items.Add(lv);
            }

        

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.CategoryBox.GetItemText(this.CategoryBox.SelectedItem);
            if ( selected == "Residential")
            {
                TypeBox.Items.Clear();
                TypeBox.Enabled = true;
                TypeBox.Items.Add("houses");
                TypeBox.Items.Add("villas");
                TypeBox.Items.Add("apartments");
                TypeBox.Items.Add("townhouses");
                TypeBox.SelectedIndex = 1;

            }
            if (selected == "Commercial")
            {
                TypeBox.Items.Clear();
                TypeBox.Enabled = true;
                TypeBox.Items.Add("shops");
                TypeBox.Items.Add("warehouse");
                TypeBox.SelectedIndex = 0;


            }
            {

            }
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddPic_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox.Image = new Bitmap(open.FileName);
        //        MessageBox.Show("Success to add a picture!");
                // image file path  
              //  textBox1.Text = open.FileName;
            }

            }

       

        private void saveChange_Click(object sender, EventArgs e)
        {
           // Now is only work for list view if u want to use listBox have to change index and if sats line 31 
            if ( UserlistView.SelectedItems.Count > 0)
            {
                
                int index = UserlistView.SelectedItems[0].Index;

                
                

                AEstate estate = rsl.GetAt(index);
              
                

              //  int id = rsl.GetId();
                estate.SetCategory(CategoryBox.Text);
                estate.SetType(TypeBox.Text);
                estate.SetLegal(LegalFormBox.Text);
                estate.SetCountry(CountryBox.Text);
                estate.SetCity(CityTxtBox.Text);
                estate.SetStreet(StreetTxtBox.Text);
                estate.SetZipCode(ZipCodeTxtBox.Text);
                estate.SetImage(pictureBox.Image);
                //estate.SetId = 
                    estate.SetId(int.Parse(IdLb.Text));
                

                Address address = new Address(CountryBox.Text, CityTxtBox.Text, StreetTxtBox.Text, ZipCodeTxtBox.Text);

                //rsl.SaveEditedItem(estate.GetId(), estate.Category(), estate.TypeEstate(), estate.Legal(), address, pictureBox.Image);

                rsl.SaveEditedItem(index ,estate.GetId(), estate.GetCategory(), estate.GetTypeEstate(), estate.GetLegal(), address, pictureBox.Image);
                

                UserItemViewer.Items.RemoveAt(index);
                UserItemViewer.Items.Insert(index, estate.GetId() + "  " + estate.GetCategory() + " " + estate.GetTypeEstate() + " " + estate.GetLegal() + " " + 
                    estate.GetCountry() +" " +estate.GetCity() + " "+estate.GetStreet()+" "+estate.GetZipCode());

                UserlistView.Items.RemoveAt(index);
                ListViewItem lv = new ListViewItem(estate.GetId().ToString());
                lv.SubItems.Add(estate.GetCategory());
                lv.SubItems.Add(estate.GetTypeEstate());
                lv.SubItems.Add(estate.GetLegal());
                lv.SubItems.Add(estate.GetCountry());
                UserlistView.Items.Insert(index, lv);
            }
        }

        private void btDeleteEstate_Click(object sender, EventArgs e)
        {

            //if (UserItemViewer.SelectedIndex > -1)
            //{

                if (UserlistView.SelectedItems.Count > 0)
                {
                    //   int index = UserItemViewer.Items.IndexOf(UserItemViewer.SelectedItem);
                int index = UserlistView.SelectedItems[0].Index;
                rsl.DeleteAt(index);
                UserItemViewer.Items.RemoveAt(index);
                UserlistView.Items.RemoveAt(index);
            }
        }

        private void deleteAllBt_Click(object sender, EventArgs e)
        {
            rsl.DeleteAll();
            UserItemViewer.DataSource = null;
            UserItemViewer.Items.Clear();

            UserlistView.Items.Clear();
            
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            UserItemViewer.DataSource = null;
            UserItemViewer.Items.Clear();

            UserlistView.Items.Clear();

            rsl.FindEstate(SearchBox.Text);
            List<AEstate> searchList = rsl.GetList("Search");


            for ( int i = 0; i <= searchList.Count-1; i++)
            {
                UserItemViewer.Items.Add(searchList[i].GetId() + "  " + searchList[i].GetCategory() + " " + searchList[i].GetTypeEstate() + " " + searchList[i].GetLegal() +
                " " + searchList[i].GetCountry() + " " + searchList[i].GetCity() + " " + searchList[i].GetStreet() + " " + searchList[i].GetZipCode());

                ListViewItem lv = new ListViewItem(searchList[i].GetId().ToString());
                lv.SubItems.Add(searchList[i].GetCategory());
                lv.SubItems.Add(searchList[i].GetTypeEstate());
                lv.SubItems.Add(searchList[i].GetLegal());
                lv.SubItems.Add(searchList[i].GetCountry());
                UserlistView.Items.Add(lv);
            }

            rsl.DeleteSubList();
            
            
        }

        private void ShowAllBt_Click(object sender, EventArgs e)
        {
            UserItemViewer.DataSource = null;
            UserItemViewer.Items.Clear();
            UserlistView.Items.Clear();

            List<AEstate> List = rsl.GetList("all");
            for (int i = 0; i <= List.Count - 1; i++)
            {
                UserItemViewer.Items.Add(List[i].GetId() + "  " + List[i].GetCategory() + " " + List[i].GetTypeEstate() + " " + List[i].GetLegal() +
                " " + List[i].GetCountry() + " " + List[i].GetCity() + " " + List[i].GetStreet() + " " + List[i].GetZipCode());

                ListViewItem lv = new ListViewItem(List[i].GetId().ToString());
                lv.SubItems.Add(List[i].GetCategory());
                lv.SubItems.Add(List[i].GetTypeEstate());
                lv.SubItems.Add(List[i].GetLegal());
                lv.SubItems.Add(List[i].GetCountry());
                UserlistView.Items.Add(lv);

            }
        }

        private void UserlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (UserlistView.SelectedItems.Count > 0)
            {
                saveChange.Enabled = true;

                int index = UserlistView.SelectedItems[0].Index;

                AEstate estate = rsl.GetAt(index);

                CategoryBox.Text = estate.GetCategory();
                TypeBox.Text = estate.GetTypeEstate();
                LegalFormBox.Text = estate.GetLegal();
                CountryBox.Text = estate.GetCountry();
                StreetTxtBox.Text = estate.GetStreet();
                CityTxtBox.Text = estate.GetCity();
                ZipCodeTxtBox.Text = estate.GetZipCode();
                pictureBox.Image = estate.GetImage();
                IdLb.Text = estate.GetId().ToString();
            }

            
        }
        private void SaveFile(List<AEstate> List,string fileName)
        {
           rsl.BinarySerialize(fileName);
            

        }

        private void SaveFileBinary(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Data Format (*.dat)|*.dat";
            saveFileDialog1.FileName = "Test.dat";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {

                SaveFile(rsl.GetList("all"), saveFileDialog1.FileName);
            }
        }

        private void OpenFileBinary(object sender, EventArgs e)
        {


            UserItemViewer.DataSource = null;
            UserItemViewer.Items.Clear();
            UserlistView.Items.Clear();

            //--------------------
            string fileName = null;

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "data files (*.dat)|*.dat";
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                }


                //---------------





                try
                {
                    rsl.BinaryDeSerialize(fileName);
                    List<AEstate> List = rsl.GetList("all");
                    for (int i = 0; i <= List.Count - 1; i++)
                    {
                        UserItemViewer.Items.Add(List[i].GetId() + "  " + List[i].GetCategory() + " " + List[i].GetTypeEstate() + " " + List[i].GetLegal() +
                        " " + List[i].GetCountry() + " " + List[i].GetCity() + " " + List[i].GetStreet() + " " + List[i].GetZipCode());

                        ListViewItem lv = new ListViewItem(List[i].GetId().ToString());
                        lv.SubItems.Add(List[i].GetCategory());
                        lv.SubItems.Add(List[i].GetTypeEstate());
                        lv.SubItems.Add(List[i].GetLegal());
                        lv.SubItems.Add(List[i].GetCountry());
                        UserlistView.Items.Add(lv);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                

            }
        }
    }
}
