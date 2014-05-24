/*
Write a function that creates a HTML UL using a template for every HTML LI.
The source of the list should an array of elements.
Replace all placeholders marked with –{…}–   
with the value of the corresponding property of the object.
*/

document.getElementById("submit").onclick = function(){
	var people =
        [ { name: 'Peter', age: 14 }
        , { name: 'Ivan',  age: 18 }
        , { name: 'Vlado', age: 17 }
        , { name: 'Joro',  age: 25 }
    ]

      , template = document.getElementById('list-item')

    template.outerHTML = generateList(people, template.innerHTML);
};

function generateList(people, template) {
    var result = '<ul>'

    people.forEach(function(human) {
        result += '<li>'

        result += template.replace(/-\{(.*?)\}-/g, function(match, p1) {
            return human[p1]
        })

        result += '</li>'
    })

    result += '</ul>'

    return result
};