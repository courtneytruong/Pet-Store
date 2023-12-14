using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Store_class_exercise;
using PetStoreProducts;


namespace PetStoreUI
{
    public interface IMenuLogic
    {
        public void WriteStartMenu(){ }

        public void WriteConfirmMenu() { }

        public static void ConfirmProductType() { }

    }
}
