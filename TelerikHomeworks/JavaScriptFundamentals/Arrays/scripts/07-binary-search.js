//Write a program that finds the most frequent number in an array.

jsConsole.writeLine("1, 2, 3, 4, 5, 6, 7, 8, 9");

jsConsole.write("Enter element you search:<br />");

document.getElementById("submit").onclick = binarySearch;

function binarySearch() {
	var array = [1,2,3,4,5,6,7,8,9],
		element = parseFloat(document.getElementById("input").value),
		minIndex = 0,
		maxIndex = array.length - 1,
		middle;

    while (maxIndex >= minIndex)
    {
        middle = parseInt(((minIndex + maxIndex) / 2 + 0.5));
        if (array[middle] < element){
            minIndex = middle + 1;
        }else if (array[middle] > element){
            maxIndex = middle - 1;
        }else{
            jsConsole.writeLine("index of " + element + " is " + middle);
            return;
        }
    }

    jsConsole.writeLine("There is no element " + element);
};