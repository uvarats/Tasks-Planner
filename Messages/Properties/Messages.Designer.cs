﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Messages.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Messages.Properties.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Вы действительно хотите закрыть приложение?
        ///
        ///Пока приложение закрыто, уведомления не будут приходить..
        /// </summary>
        public static string AreYouSure {
            get {
                return ResourceManager.GetString("AreYouSure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Вы действительно хотите удалить данный элемент? Данное действие невозможно будет отменить!.
        /// </summary>
        public static string AreYouSureWantDelete {
            get {
                return ResourceManager.GetString("AreYouSureWantDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Внимание!.
        /// </summary>
        public static string Attention {
            get {
                return ResourceManager.GetString("Attention", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Вы действительно хотите отменить все изменения?.
        /// </summary>
        public static string Cancel {
            get {
                return ResourceManager.GetString("Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Редактировать.
        /// </summary>
        public static string Edit {
            get {
                return ResourceManager.GetString("Edit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Сохранить.
        /// </summary>
        public static string Save {
            get {
                return ResourceManager.GetString("Save", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Успешно сохранено..
        /// </summary>
        public static string Saved {
            get {
                return ResourceManager.GetString("Saved", resourceCulture);
            }
        }
    }
}
