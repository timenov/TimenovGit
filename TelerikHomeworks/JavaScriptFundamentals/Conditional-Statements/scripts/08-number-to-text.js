//Write a script that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//    0 "Zero"
//    273 "Two hundred seventy three"
//    400 "Four hundred"
//    501 "Five hundred and one"
//    711 "Seven hundred and eleven"


document.getElementById("submit").onclick = sortNumbers;

function sortNumbers() {
    var number = document.getElementById("input").value;

    var ones = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"],
        tens = ["", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"],
        others = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];

    // 0 to 9
    if(number < 10) { 
        if(number == 0){
            jsConsole.writeLine("zero");
        }else{
            jsConsole.writeLine(ones[number]);
        }
    // 10 to 19
    }else if (number > 9 && number < 20){ 
        jsConsole.writeLine(others[number % 10]);
    }
    // 20 to 99
    else if (number > 19 && number < 100){ 
        jsConsole.writeLine(tens[parseInt(number / 10)] + " " + ones[number % 10]);
    }else if (number == 100){
        jsConsole.writeLine("one hundred");
    // 101 to 999
    }else if (number > 100 && number < 1000){ 
        jsConsole.write(ones[parseInt(number / 100)] + " hundred ");
        // find middle digit
        var midd = ((parseInt(number / 10)) % 10);
        // find last digit
        var last = ((number % 10) % 10);
        // *00 to *09
        if (midd == 0){ 
            jsConsole.writeLine("and " + ones[last]);
        // *10 to *19
        }else if (midd == 1){ 
            jsConsole.writeLine("and " + others[last]);
        }
        // *20 to *99
        else{ 
            jsConsole.writeLine(tens[midd] + " " + ones[last]);
        }
    }
};