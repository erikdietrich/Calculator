using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class AnswerRecorder
    {
        public virtual void WriteToFile(string textToWrite)
        {
            File.WriteAllText("answers.txt", textToWrite.ToString());
        }
    }
}
