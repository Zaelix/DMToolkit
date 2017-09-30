using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMToolkit
{
    static class PersistentListHandler
    {
                
        public static List<SimpleCharacter> getPersistentList(DMTool toolInstance)
        {
            List<SimpleCharacter> clist = new List<SimpleCharacter>();
            String localPath = AppDomain.CurrentDomain.BaseDirectory;
            if (Directory.Exists(localPath))
            {
                if (File.Exists(localPath + "/PersistentList.txt") == false)
                {
                    FileStream fs = null;
                    try
                    {
                        fs = File.Create(localPath + "/PersistentList.txt");
                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show("Unable to create PersistentList.txt, check user permissions at: " + localPath);
                        Environment.Exit(0);
                    }
                    fs.Close();
                }
                StreamReader sr = null;
                
                try
                {
                    sr = new StreamReader(localPath + "/PersistentList.txt");
                }
                catch (Exception f)
                {
                    System.Windows.Forms.MessageBox.Show("Unable to open PersistentList.txt (file opened by another program?) at: " + localPath);
                    Environment.Exit(0);
                }

                String lineContents = "";
                lineContents = sr.ReadLine();
                while (sr.Peek() >= 0)
                {
                    string[] line = lineContents.Split(' ');
                    SimpleCharacter chara = new SimpleCharacter(line[0], Convert.ToInt32(line[1]), Convert.ToInt32(line[2]), Convert.ToInt32(line[3]), Convert.ToInt32(line[4]), Convert.ToInt32(line[5]), Convert.ToInt32(line[6]), Convert.ToInt32(line[7]), Convert.ToInt32(line[8]), Convert.ToInt32(line[9]));
                    toolInstance.addCharacterToCharacterList(chara);
                    lineContents = sr.ReadLine();
                }
                sr.Close();
            }
            return clist;
        }
        
        public static void WriteListFile(List<SimpleCharacter> charaList)
        {
            String localPath = AppDomain.CurrentDomain.BaseDirectory;
            if (Directory.Exists(localPath))
            {
                FileStream outFileStream = new FileStream(localPath+"/PersistentList.txt", FileMode.Create, FileAccess.Write);
                String fileContent = charaListToString(charaList);
                Byte[] buffer = null;
                buffer = ASCIIEncoding.ASCII.GetBytes(fileContent);
                outFileStream.Write(buffer, 0, buffer.Length);
                outFileStream.Close();
            }
        }

        private static String charaListToString(List<SimpleCharacter> charaList) {
            String characters = "";
            foreach (SimpleCharacter c in charaList) {
                characters = characters + c.Name.Replace(' ', '_') + " " + c.Init + " " + c.Body + " " + c.Agility + " " + c.Reaction + " " + c.Strength + " " + c.Charisma + " " + c.Intuition + " " + c.Logic + " " + c.Willpower + "\r\n";
            }
            characters = characters + "EOF";
            return characters;
        }
    }
}
