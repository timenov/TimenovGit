//Write functions for working with shapes in  standard Planar coordinate system
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending
//L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points
//Check if three segment lines can form a triangle

document.getElementById("submit").onclick = function(){
	var pointA = new Point(1, 3),
		pointB = new Point(4, 2);

	var lineA = new Line(pointA, pointB),
		lineB = new Line(new Point(1, 1), new Point(0, 0)),
		lineC = new Line(new Point(-3, 5), new Point(-2, -5));

	jsConsole.writeLine("distance between points with coordinates p1(" + pointA.x +", " + pointA.y + ") and p2(" + pointB.x +", " + pointB.y + ") is " + calcDistance(pointA, pointB));
	jsConsole.writeLine("can lines with lengths: " + lineA.length + ", " + lineB.length + ", " + lineC.length + " form a trianlge:");
	jsConsole.writeLine(canLinesFormTriangle(lineA, lineB, lineC));
};

function Point(x, y){
	this.x = x;
	this.y = y;
};

function Line(point1, point2){
	this.point1 = point1;
	this.point2 = point2;

	this.length = calcDistance(this.point1, this.point2);
};


function calcDistance(point1, point2) {
	return Math.sqrt(Math.pow((point2.x - point1.x), 2) + Math.pow((point2.y - point1.y), 2));
};

function canLinesFormTriangle(line1, line2, line3){
	var firstPair = (line1.length + line2.length > line3.length),
		secondPair = (line1.length + line3.length > line2.length),
		thirdPair = (line2.length + line3.length > line1.length);

	return firstPair && secondPair && thirdPair;
};