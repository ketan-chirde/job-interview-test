"use client";

/*

Interview tests:

1. Write a function to reverse a string
2. Apply a bold style to the label using css, and make the two items appear on the same line
3. Add a basic header component
4. Create a component that can show the Reverse string test, and number of customers
5. Write a function to load the data from data/customers.json
6. Write a function to convert the data into the format specified in dataTests.ts
7. Display the first 100 records in a table using a separate component. While the data is loading show a basic loading state (just the text "Loading" is fine)
8. If we have time, implement a filter using a text box

*/

export default function Home() {
  const reverseStringTest = "Not implemented";
  const customerCount = 0;

  return (
    <main>
      <div>Reverse string test: {reverseStringTest}</div>
      <div>Customers: {customerCount}</div>
    </main>
  );
}
