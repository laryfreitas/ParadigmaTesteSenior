﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParadigmaTeste.Properties {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ParadigmaTeste.Properties.Resource", typeof(Resource).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -----------------------------------------------------------------------.
        /// </summary>
        internal static string Linha {
            get {
                return ResourceManager.GetString("Linha", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Existe galho(s) pai que possuem mais de dois filhos..
        /// </summary>
        internal static string MsgErro1 {
            get {
                return ResourceManager.GetString("MsgErro1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ciclo presente..
        /// </summary>
        internal static string MsgErro2 {
            get {
                return ResourceManager.GetString("MsgErro2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mais de um galho pai chama o mesmo galho filho, caracterizando raízes múltiplas..
        /// </summary>
        internal static string MsgErro3 {
            get {
                return ResourceManager.GetString("MsgErro3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não foi possivel construir a árvore. Erro: {0}.
        /// </summary>
        internal static string MsgErro4 {
            get {
                return ResourceManager.GetString("MsgErro4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arvore do cenario um:.
        /// </summary>
        internal static string Titulo1 {
            get {
                return ResourceManager.GetString("Titulo1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arvore do cenario dois:.
        /// </summary>
        internal static string Titulo2 {
            get {
                return ResourceManager.GetString("Titulo2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arvore do cenario tres:.
        /// </summary>
        internal static string Titulo3 {
            get {
                return ResourceManager.GetString("Titulo3", resourceCulture);
            }
        }
    }
}
