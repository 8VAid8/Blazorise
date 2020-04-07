﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise.AntDesign
{
    public partial class FieldLabel : Blazorise.FieldLabel
    {
        #region Members

        private ClassBuilder containerClassBuilder;

        #endregion

        #region Constructors

        public FieldLabel()
        {
            containerClassBuilder = new ClassBuilder( BuildContainerClasses );
        }

        #endregion

        #region Methods

        protected override void DirtyClasses()
        {
            containerClassBuilder.Dirty();

            base.DirtyClasses();
        }

        private void BuildContainerClasses( ClassBuilder builder )
        {
            builder.Append( "ant-col" );
            builder.Append( "ant-form-item-label" );

            if ( ColumnSize != null )
            {
                builder.Append( ColumnSize.Class( ClassProvider ) );
            }
        }

        #endregion

        #region Properties

        protected override bool UseColumnSizes => false; // disable column-size on the label, as we're going to add it on container

        protected string ContainerClassNames => containerClassBuilder.Class;

        #endregion
    }
}
