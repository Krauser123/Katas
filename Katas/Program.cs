using System;
using System.Text;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strbdr = new StringBuilder();
            strbdr.AppendLine("The Three Rules of TDD");
            strbdr.AppendLine("You are not allowed to write any production code unless it is to make a failing unit test pass.");
            strbdr.AppendLine("You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.");
            strbdr.AppendLine("You are not allowed to write any more production code than is sufficient to pass the one failing unit test.");
            strbdr.AppendLine("");
            strbdr.AppendLine("Which means the workflow is:");
            strbdr.AppendLine("");
            strbdr.AppendLine("Write a failing test. Stop writing the test as soon as it fails.");
            strbdr.AppendLine("Write the minimal production code required for the test to pass.Stop writing any code once the test passes.");
            strbdr.AppendLine("Refactor the test code and the production code without altering the functionality.All tests should pass.");

            Console.WriteLine(strbdr);
            Console.ReadLine();
        }
    }
}
