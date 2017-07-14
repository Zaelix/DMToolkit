using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMToolkit
{
    public partial class DMTool : Form
    {
        List<SimpleCharacter> charList = new List<SimpleCharacter>();
        SimpleCharacter[] initTrackerArr = new SimpleCharacter[100];
        List<SimpleCharacter> initTrackerList = new List<SimpleCharacter>();
        int trackedCount = 0;

        public DMTool()
        {
            InitializeComponent();
            MakeInitTracker();
        }

        private void MakeInitTracker() {
            initTracker.Columns.Add("Character Name", 200);
            initTracker.Columns.Add("Initiative", 60);
        }

        private void initTracker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combatButton_Click(object sender, EventArgs e)
        {

        }

        private void charListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charListBox.SelectedItem != null)
            {
                editCharButton.Enabled = true;
                delCharButton.Enabled = true;
                SimpleCharacter chara = (SimpleCharacter)charListBox.SelectedItem;
                charNameBox.Text = chara.Name;
                charInitBox.Value = chara.Init;
            }
            else {
                editCharButton.Enabled = false;
                delCharButton.Enabled = false;
            }
        }

        private void createCharButton_Click(object sender, EventArgs e)
        {
            SimpleCharacter chara = new SimpleCharacter(charNameBox.Text, (int)charInitBox.Value);
            charListBox.DataSource = null;
            charList.Add(chara);

            charListBox.DataSource = charList;
            charListBox.ValueMember = "Name";
            charListBox.DisplayMember = "name";
        }

        private void charInitBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addToTrackerButton_Click(object sender, EventArgs e)
        {
            if (charListBox.SelectedItem != null)
            {
                SimpleCharacter chara = (SimpleCharacter)charListBox.SelectedItem;
                initTrackerArr[trackedCount] = chara;
                initTrackerList.Add(chara);
                trackedCount++;
                String[] arr = { chara.Name, chara.Init.ToString() };
                ListViewItem lvi = new ListViewItem(arr);
                initTracker.Items.Add(lvi);
            }
        }

        private ListViewItem[] makeLVIAFromArray(List<SimpleCharacter> initList) {
            ListViewItem[] lvia = new ListViewItem[initList.Count];
            int i = 0;
            foreach (SimpleCharacter sc in initList) {
                if (sc != null)
                {
                    String[] arr = { sc.Name, sc.Init.ToString() };
                    lvia[i] = new ListViewItem(arr);
                    i++;
                }
            }
            return lvia;
        }

        private void sortTracker() {
            initTracker.Sorting = SortOrder.Descending;
        }

        private void editCharButton_Click(object sender, EventArgs e)
        {
            if (charListBox.SelectedItem != null)
            {
                SimpleCharacter chara = new SimpleCharacter(charNameBox.Text, (int)charInitBox.Value);
                charList[charListBox.SelectedIndex] = chara;
                charListBox.DataSource = null;
                //charList.RemoveAt(charListBox.SelectedIndex-1);
                //charList.Insert(charListBox.SelectedIndex, chara);
                charListBox.DataSource = charList;
                charListBox.ValueMember = "Name";
                charListBox.DisplayMember = "name";
            }
        }

        private void initTrackerSortButton_Click(object sender, EventArgs e)
        {
            initTracker.Items.Clear();
            initTrackerList = initTrackerList.OrderByDescending(SimpleCharacter => SimpleCharacter.Init).ToList();
            ListViewItem[] lvia = makeLVIAFromArray(initTrackerList);
            initTracker.Items.AddRange(lvia);
        }
    }
    
}
