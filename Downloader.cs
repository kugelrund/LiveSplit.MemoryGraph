using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace LiveSplit.MemoryGraph
{
    class MonkeyDownloadingXML
    {
        public bool DownloadNew()
        {
            string uriToSource = "https://raw.githubusercontent.com/kugelrund/LiveSplit.MemoryGraph/master/XML/";
            string xmlFileName = "LiveSplit.MemoryGraphList.xml";
            bool result = false;
            string downloadedFileLocation = "";
            if (CheckIfXMLExists(uriToSource+ xmlFileName))
            {
                result = downloadFiles(uriToSource, xmlFileName, out downloadedFileLocation);
            }
            else
            {
                MessageBox.Show("No XML server found on a server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (result)
            {
                string currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                File.Copy(downloadedFileLocation, Path.Combine(currentPath,xmlFileName), true);
                Debug.WriteLine("COPY: " + downloadedFileLocation + " --> " + Path.Combine(currentPath, xmlFileName));
                MessageBox.Show("Successfully dowloaded new XML from a server", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Failed to download the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool downloadFiles(string sourceLocation, string file, out string tempLocation)
        {
            WebClient wbClient = new WebClient();
            wbClient.DownloadFileCompleted += WbClient_DownloadFileCompleted;
            tempLocation = Path.GetTempFileName();

            Uri tempUri;
            Uri.TryCreate(sourceLocation + file, UriKind.Absolute, out tempUri);

            try { wbClient.DownloadFile(tempUri, tempLocation); }
            catch { return false; }

            FileInfo tempFileInfo = new FileInfo(tempLocation);
            if (tempFileInfo.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void WbClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Trace.WriteLine("Error downloading file!");
            }
            else
            {
                Trace.WriteLine("Downloading file completed.");
            }
        }


        private bool CheckIfXMLExists(string uri)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                resp.Close();

                return resp.StatusCode == HttpStatusCode.OK;
            }
            catch { return false; }
        }
    }
}
