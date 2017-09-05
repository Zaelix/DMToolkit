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
            PersistentListHandler.getPersistentList(this);
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
                bodyAtrInput.Value = chara.Body;
                agilityAtrInput.Value = chara.Agility;
                reactionAtrInput.Value = chara.Reaction;
                strengthAtrInput.Value = chara.Strength;
                charismaAtrInput.Value = chara.Charisma;
                intuitionAtrInput.Value = chara.Intuition;
                logicAtrInput.Value = chara.Logic;
                willpowerAtrInput.Value = chara.Willpower;
            }
            else {
                editCharButton.Enabled = false;
                delCharButton.Enabled = false;
            }
        }

        private void createCharButton_Click(object sender, EventArgs e)
        {
            SimpleCharacter chara = new SimpleCharacter(charNameBox.Text, (int)charInitBox.Value, (int)bodyAtrInput.Value, (int)agilityAtrInput.Value, (int)reactionAtrInput.Value, 
                (int)strengthAtrInput.Value, (int)charismaAtrInput.Value, (int)intuitionAtrInput.Value, (int)logicAtrInput.Value, (int)willpowerAtrInput.Value);
            addCharacterToCharacterList(chara);
            PersistentListHandler.WriteListFile(charList);
        }

        public void addCharacterToCharacterList(SimpleCharacter chara) {
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
                addToTracker(chara);
            }
        }

        private void addToTrackerWithRollsButton_Click(object sender, EventArgs e)
        {
            if (charListBox.SelectedItem != null)
            {
                SimpleCharacter chara = (SimpleCharacter)charListBox.SelectedItem;
                Random rand = new Random();
                int totalInit = chara.Init;
                for (int i = 0; i < chara.InitDice; i++) {
                    totalInit = totalInit + rand.Next(1, 7);
                }
                chara.CurrentInit = totalInit;
                addToTracker(chara);
            }
        }

        private void addToTracker(SimpleCharacter chara) {
            initTrackerArr[trackedCount] = chara;
            initTrackerList.Add(chara);
            trackedCount++;
            String[] arr = { chara.Name, chara.CurrentInit.ToString() };
            ListViewItem lvi = new ListViewItem(arr);
            initTracker.Items.Add(lvi);
        }

        private void removeFromTrackerButton_Click(object sender, EventArgs e)
        {
            initTrackerList.RemoveAt(initTracker.SelectedIndices[0]);
            initTracker.Items.RemoveAt(initTracker.SelectedIndices[0]);
        }

        private ListViewItem[] makeLVIAFromArray(List<SimpleCharacter> initList) {
            ListViewItem[] lvia = new ListViewItem[initList.Count];
            int i = 0;
            foreach (SimpleCharacter sc in initList) {
                if (sc != null)
                {
                    String[] arr = { sc.Name, sc.CurrentInit.ToString() };
                    lvia[i] = new ListViewItem(arr);
                    i++;
                }
            }
            initTracker.Items.Clear();
            return lvia;
        }

        private ListViewItem[] sortInitTrackerItems() {
            ListViewItem[] lvia = new ListViewItem[initTracker.Items.Count];
            int count = 0;
            Console.WriteLine("Tracker Count: " + initTracker.Items.Count);
            while (initTracker.Items.Count > 0) {
                ListViewItem character = new ListViewItem();
                ListViewItem maxCha = new ListViewItem();
                int max = 0;
                foreach (ListViewItem cha in initTracker.Items)
                {
                    Console.WriteLine("Text: " + cha.Text + ", Value: " + cha.SubItems[1].Text);
                    int chaInit = Convert.ToInt32(cha.SubItems[1].Text);
                    if (chaInit > max) {
                        max = chaInit;
                        maxCha = cha;
                        String[] arr = { cha.Text, cha.SubItems[1].Text };
                        character = new ListViewItem(arr);
                    }
                }
                initTracker.Items.Remove(maxCha);
                lvia[count] = character;
                count++;
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
                SimpleCharacter chara = new SimpleCharacter(charNameBox.Text, (int)charInitBox.Value, (int)bodyAtrInput.Value, (int)agilityAtrInput.Value, (int)reactionAtrInput.Value,
                    (int)strengthAtrInput.Value, (int)charismaAtrInput.Value, (int)intuitionAtrInput.Value, (int)logicAtrInput.Value, (int)willpowerAtrInput.Value);
                charList[charListBox.SelectedIndex] = chara;
                charListBox.DataSource = null;
                //charList.RemoveAt(charListBox.SelectedIndex-1);
                //charList.Insert(charListBox.SelectedIndex, chara);
                charListBox.DataSource = charList;
                charListBox.ValueMember = "Name";
                charListBox.DisplayMember = "name";
            }
            PersistentListHandler.WriteListFile(charList);
        }

        private void delCharButton_Click(object sender, EventArgs e)
        {
            charList.RemoveAt(charListBox.SelectedIndex);
            charListBox.DataSource = null;
            charListBox.DataSource = charList;
            charListBox.ValueMember = "Name";
            charListBox.DisplayMember = "name";
            PersistentListHandler.WriteListFile(charList);
        }

        private void initTrackerSortButton_Click(object sender, EventArgs e)
        {
            initTrackerList = initTrackerList.OrderByDescending(SimpleCharacter => SimpleCharacter.CurrentInit).ToList();
            ListViewItem[] lvia = sortInitTrackerItems();
            initTracker.Items.AddRange(lvia);
        }

    }
    
}
