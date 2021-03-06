// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S11.1.1_A4.1;
 * @section: 11.1.1;
 * @assertion: Being in anonymous code, "this" and eval("this"), called as a function, return the global object;
 * @description: Creating function with new Function() constructor;
*/

//CHECK#1
var MyFunction = new Function("return this");
if (MyFunction() !== this) {
  $ERROR('#1: var MyFunction = new Function("return this"); MyFunction() === this. Actual: ' + (MyFunction()));  
}

//CHECK#2
var MyFunction = new Function("return eval(\'this\')");
if (MyFunction() !== this) {
  $ERROR('#2: var MyFunction = new Function("return eval(\'this\')"); MyFunction() === this. Actual: ' + (MyFunction()));  
}


