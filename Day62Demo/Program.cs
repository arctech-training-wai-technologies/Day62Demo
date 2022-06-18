// See https://aka.ms/new-console-template for more information
/*
1.generics
----------
2.Dependancy Injection
3.Await and Async
-----------------
*/

// Data parameters

using Day62Demo;

//GenericsTest.Demo();
AwaitAsyncTest.SaveFile();
await Jump();

await AwaitAsyncTest.EntityFrameworkDemo();

async Task Jump()
{
    await AwaitAsyncTest.SaveFile2();
}