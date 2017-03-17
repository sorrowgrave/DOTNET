using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSec04
{
    public class FileIO
    {
        FileStream fstream;
        StreamWriter writer;
        public FileIO()
        {

        }

        public void Write(string path, string data)
        {
            try
            {
                    fstream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    writer = new StreamWriter(fstream);

                    //writer.Flush();
                    writer.Write(data);
                    
            }
            catch(DirectoryNotFoundException ex)
            {
                MessageBox.Show("Directory not found: " + ex);
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("File not found: " + ex);
            }
            catch(IOException ex)
            {
                MessageBox.Show("Problem writing to file: " + ex);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong writing to file: " + ex);
            }
            finally
            {
                writer.Close();
                fstream.Close();
            }
        }

        public string Read(string path)
        {
            string data = null;

            try
            {
                data = File.ReadAllText(path);
            }
            catch(DirectoryNotFoundException ex)
            {
                MessageBox.Show("Directory not found: " + ex);
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("File not found: " + ex);
            }
            catch(IOException ex)
            {
                MessageBox.Show("Problem writing to file: " + ex);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong writing to file: " + ex);
            }

            return data;
        }

        public void WriteBytes(string fileName, byte[] data)
        {
            System.IO.FileStream _FileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            // Writes a block of bytes to this stream using data from
            // a byte array.
            _FileStream.Write(data, 0, data.Length);

            // close file stream
            _FileStream.Close();
        }

    }
}
