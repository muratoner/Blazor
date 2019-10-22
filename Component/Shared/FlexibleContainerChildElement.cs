using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Component.Shared
{
    public abstract class FlexibleContainerChildElement<TParent> : ContainerChildElement<TParent>
    {
        [Parameter]
        public virtual ElementType ElementType { get; set; } = ElementType.Div;

        protected override ElementType ContainerElementType => ElementType;
    }
}
