//Write a function to count the number of divs on the web page

document.getElementById("submit").onclick = function() {jsConsole.writeLine("counts of divs: " + countOfDivs());};

function countOfDivs() {
	return document.getElementsByTagName('div').length;
};