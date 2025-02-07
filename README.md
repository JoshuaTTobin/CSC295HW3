# CSC295HW3

To ensure the GPA is within the valid range of 0 to 4, I added an "if" statement that throws an ArgumentOutOfRangeException if the GPA is out of bounds. I used the ToString() method to format the student information neatly.
In the main method, I managed a list of students with their names and GPAs. I used a Scanner object to build an interactive console menu that lets users choose from various sorting algorithms to sort the students. A while loop controlled the menu, ensuring users could navigate the sorting options and exit cleanly after making a valid choice. If an invalid option was chosen, an error message appeared.

To adapt the sorting algorithms, I modified the comparison logic to focus on the GPA property of the Student objects. The main challenge was ensuring each algorithm correctly handled these objects while maintaining the descending order requirement. For Bubble Sort, Selection Sort, and Insertion Sort, I compared the GPA values and swapped elements as needed. Merge Sort required a recursive approach, dividing the array into halves, sorting each half, and then merging them back together in descending order.

One challenge was adapting the comparison logic for custom objects. Ensuring the algorithms worked with Student objects instead of primitive data types required careful adjustments. Another challenge was handling user input validation and exceptions gracefully. Using try-catch blocks and input validation techniques helped overcome these issues. 

Each sorting algorithm successfully sorts the students by GPA in descending order, demonstrating the effective integration of sorting logic into the console application. This project was a great exercise in applying and adapting sorting algorithms for custom objects, handling user input, and ensuring the application runs smoothly with proper error handling and validation.

