using System;
using System.Collections.Generic;

using ITEA_Collections.Common;

namespace ITEA_Collections.Usings
{
    internal class GenericListUsing : IBaseCollectionUsing
    {
        public List<string> List { get; set; }

        public GenericListUsing()
        {
            List = new List<string>();
        }

        public void Add(object ts)
        {
            //List.Add("1");

            List.Add(ts);
            throw new NotImplementedException();
        }

        public void AddMany(object[] ts)
        {
            
            //List.AddRange(new string {"i", "t", "e", "a"});
            if(ts is null){
            ToConsole($"List object is null", ConsoleColor.Red);
            }
            else{
            List.AddRange(ts);
            }
            throw new NotImplementedException();
        }

        public void Clear()
        {
            List.Clear();
          //  List.RemoveAll();
            throw new NotImplementedException();
        }

        public object[] GetAll()
        {
          //  Console.WriteLine("Get all list" , List.Count);
            return List.GetRange(0,List.Count).ToArray();
            throw new NotImplementedException();
        }

        public object GetByID(int index)
        {
            try{

                return List[index];

               }
            catch(Exception ex){
                ToConsole(ex.GetType().Name + ex.Message);
                ToConsole($"No element with index: {index} ", ConsoleColor.Red);
                return null;
                 }

          //  List.IndexOf();
          //  List.FindById();
          //  List.FindAll();
            throw new NotImplementedException();
        }

        public void RemoveByID(int index)
        {
            try{
            List.RemoveAt(index);
            Console.WriteLine(index);
                }
            catch(ArgumentOutOfRangeException){
             ToConsole($"No element with {index}" , ConsoleColor.Cray);

            }
            throw new NotImplementedException();
        }

        public void ShowAll()
        {
            foreach(string lists in GetAll()){
            Console.WriteLine(lists, List.IndexOf(), lists.GetType());
            }
            throw new NotImplementedException();
        }
    }
}
