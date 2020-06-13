//What is the output?


function test() {
   console.log(a);
   console.log(foo1());
   console.log(foo2());
   
   var a = 1;
   
   function foo1() {
      return "foo1"
   }
   
   var foo2 = function() {
       return "foo2";
   };
}


test();

/*
    Answer:

*/