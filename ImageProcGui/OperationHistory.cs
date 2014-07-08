using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Drawing;

namespace ImageProc
{
    class OperationHistory
    {
        private string m_historyDataPath = string.Empty;
        private List<string> m_historyList = new List<string>();
        private int m_currentIndex = 0;
        public OperationHistory()
        {
            InitHistoryDataPath();
        }

        ~OperationHistory()
        {
            if (m_historyDataPath != string.Empty)
            {
                try
                {
                    Directory.Delete(m_historyDataPath, true);
                }
                catch (System.Exception)
                {
                	
                }

            }
        }

        public void SetEditImage(string filepath)
        {
            m_historyList.Clear();
            m_currentIndex = 0;
            m_historyList.Add(filepath);
        }

        private void InitHistoryDataPath()
        {
            try
            {
                m_historyDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TinyImage\\Cache\\";
                if (!Directory.Exists(m_historyDataPath))
                {
                    Directory.CreateDirectory(m_historyDataPath);
                }

            }
            catch (System.Exception)
            {
                m_historyDataPath = string.Empty;
            }
        }

        public void AddHistory(Bitmap bitmap)
        {
            try
            {
                int count = m_historyList.Count;
                if (m_currentIndex < (count - 1))
                {
                    m_historyList.RemoveRange(m_currentIndex + 1, count - m_currentIndex - 1);
                }
                string newfilepath = m_historyDataPath + Guid.NewGuid().ToString() + ".jpg";
                bitmap.Save(newfilepath);
                m_currentIndex++;
                m_historyList.Add(newfilepath);
            }
            catch (System.Exception)
            {
            	
            }
        }

        public Bitmap Undo()
        {
            Bitmap bitmap = null;
            if (m_currentIndex != 0)
            {
                try
                {
                    m_currentIndex--;
                    string filepath = m_historyList[m_currentIndex];
                    bitmap = new Bitmap(filepath);
                }
                catch (System.Exception)
                {
                	
                }
            }
            return bitmap;
        }

        public Bitmap Redo()
        {
            Bitmap bitmap = null;
            if (m_currentIndex < m_historyList.Count -1)
            {
                try
                {
                    m_currentIndex++;
                    string filepath = m_historyList[m_currentIndex];
                    bitmap = new Bitmap(filepath);
                }
                catch (System.Exception)
                {

                }
            }
            return bitmap;
        }

    }

}
