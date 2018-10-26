using System;
using System.Collections.Generic;
using System.Linq;

class ListWords
{

    protected class Words
    {
        private string word;
        public string Word
        {
            get
            {

            }
            set
            {

            }
        }
        private ushort amount;
        public ushort Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Не может быть отрицательным");
                }
                else amount = value;
            }
        }
    }

    List<Words> list = new List<Words>();

    Words item;


    protected bool FindKeyword(string word)
    {
        foreach (Words l in list)
        {
            if (String.Compare(l.Word, word) == 0)
                return true;
        }
        return false;
    }

    public void ShapeList(string w)
    {
        if (list.Count == 0)
        {
            list.Add(new Words() { Word = w, Amount = 1 });

        }
        else
        {
            if (FindKeyword(w))
            {
                item = list.Find(x => x.Word.Contains(w));
                item.Amount++;
            }
            else
            {
                list.Add(new Words() { Word = w, Amount = 1 });
            }
        }

    }


}
