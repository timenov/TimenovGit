
document.getElementById('print-on-console').onclick = function() {
	console.log(getInput(document.getElementById('input')));
};

function getInput(element) {
	return element.value;
};