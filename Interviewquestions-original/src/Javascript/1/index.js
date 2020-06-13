// what will the following piece of code do?

var foo = 'hello';
(function() {
  var foo = foo || 'world';
  console.log(foo);
})();
console.log(foo);

/* Answer: 

*/