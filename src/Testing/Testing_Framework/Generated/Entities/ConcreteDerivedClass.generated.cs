//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity.Spatial;

namespace Testing
{
   public partial class ConcreteDerivedClass : AbstractBaseClass
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public ConcreteDerivedClass(): base()
      {
         Init();
      }

      // Persistent properties

      public string Property1 { get; set; }

      public string PropertyInChild { get; set; }

   }
}

