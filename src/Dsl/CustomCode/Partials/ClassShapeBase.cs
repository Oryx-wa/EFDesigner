﻿using System.Drawing;
using Microsoft.VisualStudio.Modeling;

namespace Sawczyn.EFDesigner.EFModel
{
   public abstract partial class ClassShapeBase
   {
      private static string GetDisplayPropertyFromModelClassForAttributesCompartment(ModelElement element)
      {
         ModelAttribute attribute = (ModelAttribute)element;
         return $"{attribute.Name} : {attribute.Type}{(attribute.Required ? "" : "?")}{(attribute.MaxLength > 0 ? "[" + attribute.MaxLength + "]" : "")}";
      }

      internal sealed partial class FillColorPropertyHandler
      {
         protected override void OnValueChanging(ClassShapeBase element, Color oldValue, Color newValue)
         {
            base.OnValueChanging(element, oldValue, newValue);

            if (element.Store.InUndoRedoOrRollback || element.Store.InSerializationTransaction)
               return;

            // set text color to contrasting color based on new fill color
            element.TextColor = newValue.LegibleTextColor();
         }
      }

      private bool GetVisibleValue()
      {
         return IsVisible;
      }

      private void SetVisibleValue(bool newValue)
      {
         if (newValue)
            Show();
         else
            Hide();
      }
   }
}