
document.getElementById('print-on-console').onclick = function() {
	var backgroundColor = getInput(document.getElementById('input'));

	document.querySelector('div>p').style.color = backgroundColor;
	document.body.style.background = backgroundColor;
};

function getInput(element) {
	return element.value;
};