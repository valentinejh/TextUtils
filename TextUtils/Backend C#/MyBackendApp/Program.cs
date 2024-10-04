using System;
using System.Web.UI;

namespace TextUtils
{
    public partial class Default : Page
    {
        protected void btnCount_Click(object sender, EventArgs e)
        {
            string inputText = inputText.Value; // Get the input text from the textarea

            word_count(inputText);
            character_count(inputText);
            letter_count(inputText);
        }

        private void word_count(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    count++;
                }
            }
            int wordCount = count + 1;
            lblWordCount.Text = "Word count: " + wordCount;
        }

        private void character_count(string text)
        {
            int count = text.Length;
            lblCharacterCount.Text = "Character count: " + count;
        }

        private void letter_count(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    count++;
                }
            }
            lblLetterCount.Text = "Letter count: " + count;
        }
    }
}

