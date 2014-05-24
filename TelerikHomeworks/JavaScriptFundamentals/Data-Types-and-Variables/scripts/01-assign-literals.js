jsConsole.writeLine("1. Assign all the possible JavaScript literals to different variables.<br />");

var bool = true;
var integer = 5;
var floatingPoint = 3.141592;
var string = "Hello JavaScript";
var array = {0: bool, 1: integer, 2: floatingPoint, 3: string};

jsConsole.writeLine("boolean: " + bool);
jsConsole.writeLine("integer: " + integer);
jsConsole.writeLine("float: " + floatingPoint);
jsConsole.writeLine("string: " + string);
jsConsole.writeLine("object(array): {" + array[0] + ", " + array[1] + ", " + array[2] + ", " + array[3] + "}");