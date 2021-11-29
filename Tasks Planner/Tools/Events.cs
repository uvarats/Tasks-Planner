﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Presenters;

namespace Tasks_Planner.Tools
{
    public class Events
    {
        public static MainPresenter? MainPresenter { get; set; }
        public static CategoriesPresenter? CategoriesPresenter { get; set; }
        public static void TasksListChanged()
        {
            if (MainPresenter != null)
            {
                MainPresenter.UpdateTasksList();
            }
            else throw new ArgumentException(typeof(Events).ToString());
        }
        public static void CategoriesListChanged()
        {
            if (CategoriesPresenter != null)
            {
                CategoriesPresenter.UpdateCategoriesList();
            }
            else throw new ArgumentException(typeof(Events).ToString());
        }
    }
}