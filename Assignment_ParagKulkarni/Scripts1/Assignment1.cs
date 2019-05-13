
//Convert the string to Title Case and Camel case.
using System;

namespace Scripts1
{
    public class Assignment1
    {
        string input = "csharp Corner Home", appentstr = null,finalstr=null;
        string[] output = null;
        public string[] toTitleCase()
        {
            string[] strsplit = input.Split(" ");
            for (int i = 0; i < strsplit.Length; i++)
            {
                //char[] strarr=strsplit[i].ToCharArray();
                //output[i]=strarr[0].ToString().ToUpper();
                for (int j = 0; j < strsplit[i].Length; j++)
                {
                    if(j==0)
                    {
                    appentstr = strsplit[i][j].ToString().ToUpper();
                    }else{
                            appentstr += strsplit[i][j].ToString().ToLower();
                    }
                }
                finalstr +=appentstr;

            }

            return output;
        }
    }
}
