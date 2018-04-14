using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.Text.RegularExpressions;


namespace k_14_2233
{
    public partial class Form1 : Form
    {
        List<document> docs = new List<document>();
        class document
        {
            public int docid { get; set; }

            public string title { get; set; }

            public string content { get; set; }


             




        }



        public Form1()
        {
            InitializeComponent();
            string line;
            int docid = 0;
            string title = "";

            List<int> l = new List<int>();
            
          

            String s = "";

            // Split file into document objects 
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"../../Quran Translation.txt", System.Text.Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dam = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();









            file =
                new System.IO.StreamReader(@"../../1.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();






            // 2


            file =
             new System.IO.StreamReader(@"../../2.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag1 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();







            // 3


            file =
             new System.IO.StreamReader(@"../../3.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag2 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();






            // 4


            file =
             new System.IO.StreamReader(@"../../4.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag4 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();






            // 5


            file =
             new System.IO.StreamReader(@"../../5.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag5 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();






            // 6


            file =
             new System.IO.StreamReader(@"../../6.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag6 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();






            // 7


            file =
             new System.IO.StreamReader(@"../../7.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag7 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();









            // 8


            file =
             new System.IO.StreamReader(@"../../8.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag8 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();







            // 9


            file =
             new System.IO.StreamReader(@"../../9.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    string[] k = line.Split(' ');


                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag9 = new document();

            docid++;
            dag9.title = title;
            dag9.docid = docid;
            dag9.content = s;

            docs.Add(dag9);

            file.Close();






            // 10


            file =
             new System.IO.StreamReader(@"../../10.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag10 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();





            // 11



            file =
             new System.IO.StreamReader(@"../../11.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag11 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();







            // 12


            file =
             new System.IO.StreamReader(@"../../12.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag12 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();







            // 13



            file =
             new System.IO.StreamReader(@"../../13.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag13 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();






            // 14


            file =
             new System.IO.StreamReader(@"../../14.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag14 = new document();

            docid++;
            dam.title = title;
            dam.docid = docid;
            dam.content = s;

            docs.Add(dam);

            file.Close();





            // 15


            file =
             new System.IO.StreamReader(@"../../15.txt", System.Text.Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {



                if (line.Contains("["))
                {

                    if (!String.IsNullOrEmpty(s))
                    {
                        docid++;

                        document d = new document();

                        d.title = title;
                        d.docid = docid;
                        d.content = s;

                        docs.Add(d);

                        s = "";



                    }

                    title = line;
                    //   Console.WriteLine(title);


                    //  Console.WriteLine("document title  " + title + "\n" );


                }

                else
                {
                    s = s + line + " ";
                }




                // System.Console.WriteLine(line);







                /*
                                string[] words = line.Split(' ');
                                foreach (string word in words)
                                {
                                    Console.WriteLine(word + "\n");
                                }


                    */


            }


            document dag15 = new document();

            docid++;
            dag15.title = title;
            dag15.docid = docid;
            dag15.content = s;

            docs.Add(dag15);

            file.Close();



            // read first hadees file

























            /*
           String b = "";

                         

            foreach (var v in docs)
            {
                // Console.WriteLine("doc title: " + v.title + "  ->  " + v.content + "\n" );

                b = "doc title: " + v.title + "  ->  " + v.content;

               System.IO.File.AppendAllText(@"d:\hello.txt", b + Environment.NewLine);

            }
            */



        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            




















            // construct inverted index  
            SortedDictionary<string, List<int>> dictionary =
           new SortedDictionary<string, List<int>>();


            SortedDictionary<string, List<int>> positional_index =
          new SortedDictionary<string, List<int>>();


            int pos_counter = 0;





            // list to store stopwords
            List<string> stopwords = new List<string>();


            string stop = "";


            // read stopwords from file and add them to list
            System.IO.StreamReader stopfile =
               new System.IO.StreamReader(@"../../Stopword-List.txt", System.Text.Encoding.Default);
            while ((stop = stopfile.ReadLine()) != null)
            {
                stopwords.Add(stop);
                // System.IO.File.AppendAllText(@"../../inverted_index.txt", stop + Environment.NewLine);

            }






            if (System.IO.File.Exists((@"../../_Inverted_index.txt")) && System.IO.File.Exists((@"../../_Position_index.txt")))
            {

                string in_index = System.IO.File.ReadAllText(@"../../_Inverted_index.txt");
                string posi_index = System.IO.File.ReadAllText(@"../../_Positional_index");

                dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<SortedDictionary<string, List<int>>>(in_index);
                positional_index = Newtonsoft.Json.JsonConvert.DeserializeObject<SortedDictionary<string, List<int>>>(posi_index);


            }



            else
            {
                // case folding , tokenize each document and construct inverted index + positional index 
                foreach (var v in docs)
                {



                    List<int> test = new List<int>();
                    test.Add(v.docid);
                    string content = v.content;
                    content = content.Replace("'", "s");
                    content = content.Replace(".", string.Empty);
                    content = Regex.Replace(content, "[^a-zA-Z0-9_.]+", " ", RegexOptions.Compiled);

                    content = content.TrimStart();

                    content = content.ToLower();

                    string[] words = content.Split(' ');
                    foreach (string word in words)
                    {

                        pos_counter++;

                        List<int> t = new List<int>();
                        t.Add(v.docid);

                        if (!stopwords.Contains(word))
                        {
                            if(word != "of")
                            { 
                            if (dictionary.ContainsKey(word))
                            {
                                dictionary[word].Add(v.docid);

                                string position_key = word + v.docid;




                                if (positional_index.ContainsKey(position_key))
                                    positional_index[position_key].Add(pos_counter);



                                else
                                {
                                    List<int> positions = new List<int>();
                                    positions.Add(pos_counter);

                                    positional_index.Add(position_key, positions);

                                }




                            }

                            else
                            {
                                dictionary.Add(word, t);

                                string position_key = word + v.docid;


                                List<int> positions = new List<int>();
                                positions.Add(pos_counter);

                                positional_index.Add(position_key, positions);









                            }

                        }

                        }
                    }

                    pos_counter = 0;

                }


                positional_index.OrderByDescending(x => x.Value).Select(p => p.Key);




                string inv_index = Newtonsoft.Json.JsonConvert.SerializeObject(dictionary, Newtonsoft.Json.Formatting.Indented);

                System.IO.File.WriteAllText(@"../../_Inverted_index.txt", inv_index);


                string pos_index = Newtonsoft.Json.JsonConvert.SerializeObject(positional_index, Newtonsoft.Json.Formatting.Indented);

                System.IO.File.WriteAllText(@"../../_Positional_index.txt", pos_index);


            }


            // list containing all document id's
            List<int> alldocids = new List<int>();
            foreach (var v in docs)
            {
                alldocids.Add(v.docid);
            }





            // quering inverted index

            string query = textBox3.Text;
            query = query.TrimEnd();



            query = query.Replace("'", "s");
            query = query.Replace(".", string.Empty);
            query = Regex.Replace(query, "[^a-zA-Z0-9_.]+", " ", RegexOptions.Compiled);

            query = query.TrimStart();



            Console.WriteLine(query);

            string[] query_terms = query.Split();






            List<int> t1 = new List<int>();
            List<int> t2 = new List<int>();
            List<int> t3 = new List<int>();
            List<int> temp_intersect = new List<int>();
            List<int> temp_union = new List<int>();
            List<int> temp_intersect2 = new List<int>();
            List<int> temp_union2 = new List<int>();
            List<int> pos_list1 = new List<int>();
            List<int> pos_list2 = new List<int>();
            List<int> pos_list3 = new List<int>();
            List<int> pos_list4 = new List<int>();



            string term1 = "";
            string term2 = "";
            string term3 = "";









            List<int> intersect_result = new List<int>();
            List<int> union_result = new List<int>();
            int term_index = 0;
            int operator_index = 0;
            int check = 0;
            int test1 = 0;
            int test2 = 0;
            int test3 = 0;
            int test4 = 0;
            int count = 0;


            // start of query condition with 1 term
            if (query_terms.Count() <= 2)
            {

                if (query_terms[0] == "NOT")
                {
                    dictionary.TryGetValue(query_terms[1], out t1);

                    var list3 = alldocids.Except(t1).ToList();

                    t1 = list3;
                    var d = t1.Distinct().ToList();
                    t1 = d;


                    listView1.Items.Clear();

                    foreach (var one in t1)
                    {
                        count++;
                        ListViewItem lv1 = new ListViewItem(docs[one - 1].title);
                        lv1.SubItems.Add(docs[one - 1].content);
                        listView1.Items.Add(lv1);

                       
                    }

                    textBox2.Text = count.ToString();
                    count = 0;


                }

                else
                {

                    dictionary.TryGetValue(query_terms[0], out t1);
                    var d = t1.Distinct().ToList();
                    t1 = d;


                    listView1.Items.Clear();
                    foreach (var one in t1)
                    {
                        count++;
                        ListViewItem lv1 = new ListViewItem(docs[one - 1].title);
                        lv1.SubItems.Add(docs[one - 1].content);
                        listView1.Items.Add(lv1);
                      
                    }

                    textBox2.Text = count.ToString();
                    count = 0;

                }

            }
            // end of query condition with 1 term




            else
            {

                if (query_terms[term_index] == "NOT")
                {
                    dictionary.TryGetValue(query_terms[term_index + 1], out t1);




                    var list3 = alldocids.Except(t1).ToList();
                    t1 = list3;
                    var d1 = t1.Distinct().ToList();
                    t1 = d1;

                    term1 = query_terms[term_index + 1];

                    term_index += 2;

                }


                else
                {

                    dictionary.TryGetValue(query_terms[term_index], out t1);


                    var d1 = t1.Distinct().ToList();
                    t1 = d1;


                    term1 = query_terms[term_index];

                    term_index += 1;


                }


                operator_index = term_index;


                term_index++;

                if (query_terms[term_index] == "NOT")
                {

                    dictionary.TryGetValue(query_terms[term_index + 1], out t2);

                    var list3 = alldocids.Except(t2).ToList();
                    t2 = list3;
                    var d1 = t2.Distinct().ToList();
                    t2 = d1;

                    term2 = query_terms[term_index + 1];

                    term_index += 2;

                }

                else
                {

                    dictionary.TryGetValue(query_terms[term_index], out t2);
                    var d1 = t2.Distinct().ToList();
                    t2 = d1;

                    term2 = query_terms[term_index];

                    term_index += 1;
                }

                if (query_terms[operator_index] == "AND")
                {
                    var intersect1 = t1.Intersect(t2).ToList();
                    intersect_result = intersect1;
                    check = 1;

                    // big if condition

                    if (term_index < query_terms.Count())
                    {

                        if (query_terms[term_index] != "AND" && query_terms[term_index] != "OR")
                        {

                            test1 = 1;
                            int value1 = Int32.Parse(query_terms[term_index]);

                            foreach (var x in intersect_result)
                            {

                                string y = term1 + x;

                                positional_index.TryGetValue(y, out pos_list1);

                                y = term2 + x;

                                positional_index.TryGetValue(y, out pos_list2);


                                foreach (var x1 in pos_list1)
                                {

                                    foreach (var x2 in pos_list2)
                                    {
                                        if (Math.Abs((x2 - x1) - 1) <= value1)
                                        {

                                            temp_intersect.Add(x);
                                            test2 = 1;
                                            break;

                                        }


                                    }

                                    if (test2 == 1)
                                    {
                                        test2 = 0;
                                        break;

                                    }

                                }





                            }




                            pos_list1.Clear();
                            pos_list2.Clear();



                        }

                    }


                }


                else
                {

                    var union1 = t1.Union(t2).ToList();
                    union_result = union1;

                    check = 0;

                    if (term_index < query_terms.Count())
                    {
                        if (query_terms[term_index] != "AND" && query_terms[term_index] != "OR")
                        {

                            test1 = 1;
                        }

                    }

                }

                if (test1 == 1)
                {
                    term_index++;
                }

                operator_index = term_index;



                if (operator_index < query_terms.Count())
                {

                    term_index++;


                    if (query_terms[term_index] == "NOT")
                    {

                        dictionary.TryGetValue(query_terms[term_index + 1], out t3);

                        var list3 = alldocids.Except(t3).ToList();
                        t3 = list3;
                        var d1 = t3.Distinct().ToList();
                        t3 = d1;

                        term3 = query_terms[term_index + 1];

                        term_index += 2;

                    }


                    else
                    {
                        dictionary.TryGetValue(query_terms[term_index], out t3);

                        var d1 = t3.Distinct().ToList();
                        t3 = d1;

                        term3 = query_terms[term_index];

                        term_index += 1;
                    }



                    if (query_terms[operator_index] == "AND")
                    {
                        if (check == 1)
                        {


                            if (test1 == 1)
                            {
                                var in1 = t3.Intersect(temp_intersect);

                                if (term_index < query_terms.Count())
                                {

                                    if (query_terms[term_index] != "AND" || query_terms[term_index] != "OR")
                                    {

                                        test3 = 1;

                                        int value2 = Int32.Parse(query_terms[term_index]);


                                        foreach (var z in in1)
                                        {


                                            String z1 = term2 + z;



                                            positional_index.TryGetValue(z1, out pos_list3);


                                            String z2 = term3 + z;


                                            positional_index.TryGetValue(z2, out pos_list4);



                                            listView1.Items.Clear();
                                            foreach (var y1 in pos_list3)
                                            {

                                                foreach (var y2 in pos_list4)
                                                {

                                                    if (Math.Abs((y2 - y1) - 1) <= value2)
                                                    {
                                                        count++;
                                                        ListViewItem lv1 = new ListViewItem(docs[z - 1].title);
                                                        lv1.SubItems.Add(docs[z - 1].content);
                                                        listView1.Items.Add(lv1);
                                                        temp_intersect2.Add(z);
                                                        test4 = 1;
                                                        break;

                                                    }
                                                }

                                                if (test4 == 1)
                                                {
                                                    test4 = 0;
                                                    break;
                                                }


                                            }






                                        }



                                        textBox2.Text = count.ToString();
                                        count = 0;

                                    }




                                }

                                else
                                {
                                    listView1.Items.Clear();

                                    foreach (var vb in in1)
                                    {
                                        count++;
                                        ListViewItem lv1 = new ListViewItem(docs[vb - 1].title);
                                        lv1.SubItems.Add(docs[vb - 1].content);
                                        listView1.Items.Add(lv1);
                                    }

                                    textBox2.Text = count.ToString();
                                    count = 0;
                                }



                            }



                            // 1st AND 2ND TERMS WITHOUT PROXIMATY
                            else
                            {
                                var in1 = t3.Intersect(intersect_result);


                                if (term_index < query_terms.Count())
                                {

                                    if (query_terms[term_index] != "AND" || query_terms[term_index] != "OR")
                                    {
                                        listView1.Items.Clear();
                                        test3 = 1;

                                        int value2 = Int32.Parse(query_terms[term_index]);

                                        foreach (var z in in1)
                                        {

                                            string z1 = term2 + z;



                                            positional_index.TryGetValue(z1, out pos_list3);


                                            string z2 = term3 + z;


                                            positional_index.TryGetValue(z2, out pos_list4);


                                            foreach (var y1 in pos_list3)
                                            {

                                                foreach (var y2 in pos_list4)
                                                {

                                                    if (Math.Abs((y2 - y1) - 1) <= value2)
                                                    {
                                                        count++;
                                                        ListViewItem lv1 = new ListViewItem(docs[z - 1].title);
                                                        lv1.SubItems.Add(docs[z - 1].content);
                                                        listView1.Items.Add(lv1);
                                                        temp_intersect2.Add(z);
                                                        test4 = 1;
                                                        break;

                                                    }
                                                }

                                                if (test4 == 1)
                                                {
                                                    test4 = 0;
                                                    break;
                                                }


                                            }






                                        }



                                        textBox2.Text = count.ToString();
                                        count = 0;

                                    }







                                }

                                else
                                {
                                    listView1.Items.Clear();
                                    foreach (var vb in in1)
                                    {
                                        count++;
                                        ListViewItem lv1 = new ListViewItem(docs[vb - 1].title);
                                        lv1.SubItems.Add(docs[vb - 1].content);
                                        listView1.Items.Add(lv1);
                                    }
                                    textBox2.Text = count.ToString();
                                    count = 0;
                                }



                            }


                        }    // ENDS OF INTERSECTION CONDTION WITH/WITHOUT PROXIMATY BETWEEN 1ST AND 2ND TERMS

                        else
                        {

                            var in1 = t3.Intersect(union_result);



                            if (term_index < query_terms.Count())
                            {

                                if (query_terms[term_index] != "AND" || query_terms[term_index] != "OR")
                                {

                                    listView1.Items.Clear();
                                    test3 = 1;

                                    int value2 = Int32.Parse(query_terms[term_index]);

                                    foreach (var z in in1)
                                    {

                                        string z1 = term2 + z;



                                        positional_index.TryGetValue(z1, out pos_list3);


                                        string z2 = term3 + z;


                                        positional_index.TryGetValue(z2, out pos_list4);


                                        foreach (var y1 in pos_list3)
                                        {

                                            foreach (var y2 in pos_list4)
                                            {

                                                if (Math.Abs((y2 - y1) - 1) <= value2)
                                                {
                                                    count++;
                                                    ListViewItem lv1 = new ListViewItem(docs[z - 1].title);
                                                    lv1.SubItems.Add(docs[z - 1].content);
                                                    listView1.Items.Add(lv1);
                                                    temp_intersect2.Add(z);
                                                    test4 = 1;
                                                    break;

                                                }
                                            }

                                            if (test4 == 1)
                                            {
                                                test4 = 0;
                                                break;
                                            }


                                        }






                                    }


                                    textBox2.Text = count.ToString();
                                    count = 0;


                                }







                            }

                            else
                            {
                                listView1.Items.Clear();
                                foreach (var vb in in1)
                                {
                                    count++;
                                    ListViewItem lv1 = new ListViewItem(docs[vb - 1].title);
                                    lv1.SubItems.Add(docs[vb - 1].content);
                                    listView1.Items.Add(lv1);
                                }
                                textBox2.Text = count.ToString();
                                count = 0;
                            }



                        }

                    }





                    // START CONDTIONS OF OR OPERATOR WITH 3RD TERM WITH/WITHOUT PROXIMATY
                    else
                    {
                        if (check == 1)
                        {

                            if (test1 == 1)
                            {
                                listView1.Items.Clear();
                                var in1 = t3.Union(temp_intersect);
                                foreach (var x1 in in1)
                                {
                                    count++;
                                    ListViewItem lv1 = new ListViewItem(docs[x1 - 1].title);
                                    lv1.SubItems.Add(docs[x1 - 1].content);
                                    listView1.Items.Add(lv1);
                                }
                                textBox2.Text = count.ToString();
                                count = 0;
                            }

                            else
                            {
                                listView1.Items.Clear();
                                var in1 = t3.Union(intersect_result);
                                foreach (var x1 in in1)
                                {
                                    count++;
                                    ListViewItem lv1 = new ListViewItem(docs[x1 - 1].title);
                                    lv1.SubItems.Add(docs[x1 - 1].content);
                                    listView1.Items.Add(lv1);
                                }
                                textBox2.Text = count.ToString();
                                count = 0;
                            }


                        }

                        else
                        {
                            listView1.Items.Clear();

                            var in1 = t3.Union(union_result);

                            foreach (var x1 in in1)
                            {
                                count++;
                                ListViewItem lv1 = new ListViewItem(docs[x1 - 1].title);
                                lv1.SubItems.Add(docs[x1 - 1].content);
                                listView1.Items.Add(lv1);
                            }
                            textBox2.Text = count.ToString();
                            count = 0;
                        }
                    }



                }

                else
                {
                    if (check == 1)
                    {

                        if (test1 == 1)
                        {
                            listView1.Items.Clear();
                            foreach (var m1 in temp_intersect)
                            {
                                count++;
                                ListViewItem lv1 = new ListViewItem(docs[m1 - 1].title);
                                lv1.SubItems.Add(docs[m1 - 1].content);
                                listView1.Items.Add(lv1);
                            }
                            textBox2.Text = count.ToString();
                            count = 0;

                        }


                        else
                        {
                            listView1.Items.Clear();
                            foreach (var m1 in intersect_result)
                            {

                                count++;
                                ListViewItem lv1 = new ListViewItem(docs[m1 - 1].title);
                                lv1.SubItems.Add(docs[m1 - 1].content);
                                listView1.Items.Add(lv1);
                            }
                            textBox2.Text = count.ToString();
                            count = 0;

                        }
                    }
                    else
                    {
                        listView1.Items.Clear();

                        foreach (var m2 in union_result)
                        {
                            count++;
                            ListViewItem lv1 = new ListViewItem(docs[m2 - 1].title);
                            lv1.SubItems.Add(docs[m2 - 1].content);
                            listView1.Items.Add(lv1);
                        }
                        textBox2.Text = count.ToString();
                        count = 0;

                    }


                }

            }

























































            System.Console.ReadLine();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
