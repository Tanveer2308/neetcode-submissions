public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder s = new StringBuilder();
       
        foreach(var str in strs)
        {
            s.Append(str.Length);
            s.Append("#");
            s.Append(str);
          //s += str.Length + "#" + str;
        }
        //Console.WriteLine("s "+ s);
        return s.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while(i< s.Length)
        {
            int hashIndex = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, hashIndex-i));
            int stringStart = hashIndex +1;
            string word = s.Substring(stringStart, length);
            result.Add(word);

            i = stringStart + length;    
        }

        return result;

        
   }
}
