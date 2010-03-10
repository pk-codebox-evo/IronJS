﻿namespace IronJS.Runtime.Js {
	public class IjsClosure {
		public readonly IjsObj Globals;
		public readonly IjsContext Context;

		public IjsClosure(IjsContext context, IjsObj globals) {
			Globals = globals;
			Context = context;
		}
	}
}