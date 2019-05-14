//Count the no of words in a string
//Count the distinct words in a string.
using System;
using System.Collections.Generic;
namespace Scripts1
{
    public class Assignment2
        {
            public int CountWords(string input)
            {
                string[] words= input.Split(' ');
                int count = words.Length;
                return count;
            }
            public int CountDistinctWords(String input)
            {
                int count=0;
                string[] word = input.Split(' ');
                List<String> distinctWords = new List<String>();
              // distinctWords[0]=word[0];
               for(int i =0;i<word.Length; i++)
                {
                    
                        if(!distinctWords.Contains(word[i]))
                        {
                            distinctWords.Add(word[i]);
                            Console.WriteLine(word[i]);
                            count++;
                        }
                
                   

                }
                
                return count;
            }


        }
}
