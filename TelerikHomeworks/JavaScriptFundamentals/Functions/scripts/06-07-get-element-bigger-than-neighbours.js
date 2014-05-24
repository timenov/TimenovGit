//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
//Write a function that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//	Use the function from the previous exercise.


var array = [1,1,2,3,4,4,4,3,6,6,6,7,8,9,9];

jsConsole.writeLine(array);

document.getElementById("submit").onclick = function() {jsConsole.writeLine(getFirstBiggerThanNeighbors(array))};

function isBiggerThanNeighbors(array, index) {
    if (index > 0 && index < array.length - 1) {
        if (array[index] > array[index - 1] && array[index] > array[index + 1]) {
            return true;
        }
    }

    return false;
}

function getFirstBiggerThanNeighbors(array) {
	var i;

	for (i = 0; i < array.length; i++) {
		if (isBiggerThanNeighbors(array, i)) {
			return i;
		}
	}

	return -1;
}