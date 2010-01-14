﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronJS.Runtime.Js;

namespace IronJS.Runtime
{
    using Et = System.Linq.Expressions.Expression;
    using Meta = System.Dynamic.DynamicMetaObject;

    public class Function : Obj, IFunction
    {
        public Function(IFrame frame, Lambda lambda)
        {
            Frame = frame;
            Lambda = lambda;
        }

        #region IFunction Members

        public IFrame Frame
        {
            get;
            set;
        }

        public Lambda Lambda
        {
            get;
            set;
        }

        public IObj Construct()
        {
            return Context.CreateObject(this);
        }

        #endregion

        #region IDynamicMetaObjectProvider Members

        public Meta GetMetaObject(Et parameter)
        {
            return new IFunctionMeta(parameter, this);
        }

        #endregion
    }
}
