using System;

namespace VSConsoleApp1.Solutions
{

/*
    // use as main method

    class Program
    {
        private static void Main(string[] args) 
        {
            int[] testInput = new int [][]
            {
                new int[] { 0, 1, 1, 2 },
                new int[] { 0, 5, 0, 0 }, 
                new int[] { 2, 0, 3, 3 } 
            };   

            Boolean testOutput = AlmostIncreasingSequence.Run(testInput);

            Console.WriteLine($"Test val: {testOutput}");
        } 
    }

    // this solution was not executing quickly enough but otherwise passed all tests
*/

    internal struct AlmostIncreasingSequence
    {
            public static bool Run(int[] sequence) {
            int[] sequenceWithElementRemoved;
            bool itemRemoved = false;

            if (sequence.Length==2) {
                // test right away for only two elements
                if(sequence[1] >= sequence[0]) {
                    return true;
                } else {
                    return false;
                }
            }

            for(int i = 1; i<sequence.Length; i++)
            {
                Console.WriteLine($"Array: {i}, elements: {sequence[i]} and {sequence[i-1]}");
                // check regular sequence
                if(sequence[i] > sequence[i-1]) {
                    Console.WriteLine("-- Sequence is normal");
                    continue;
                } else if (!itemRemoved) {
                    Console.WriteLine("-- Sequence is off; item remove available");
                    int indexToRemoveFrom = 0;

                    // make a new array with one less element
                    sequenceWithElementRemoved = new int[sequence.Length-1];

                    // save amount of tests required (2 if element cannot be determined)
                    int testsRequired = 1;

                    // determine which index caused the issue
                    if (i == sequence.Length-1) {
                        // save item removed
                        Console.WriteLine($"Removing item from index {indexToRemoveFrom}: {sequence[indexToRemoveFrom]}");
                        itemRemoved=true;
                        indexToRemoveFrom=i;
                    } else if (i == 1) {
                        Console.WriteLine($"Removing item from index {indexToRemoveFrom}: {sequence[indexToRemoveFrom]}");
                        itemRemoved=true;
                        indexToRemoveFrom=i-1;
                    }
                    else {
                        Console.WriteLine($"Index to remove from could not be determined...");
                        // set index to remove as first item
                        indexToRemoveFrom=i-1;
                        ++testsRequired;
                    }

                    for(int l = 0; l<testsRequired; l++) {
                        // assign all elements but the one being removed
                        int indexer=0;
                        bool testFailed=false;
                        for(int j = 0; j<sequenceWithElementRemoved.Length; j++) {
                            // incremement the indexer so that we don't get the removed element from sequence
                            if (j==indexToRemoveFrom+l) indexer += 1;
                            sequenceWithElementRemoved[j] = sequence[j+indexer];
                        }

                        //check the new index
                        for(int k = 1; k<sequenceWithElementRemoved.Length; k++)
                        {
                            Console.WriteLine($"-- Sub-element: {k}, elements: {sequenceWithElementRemoved[k]} and {sequenceWithElementRemoved[k-1]}");
                            // check regular sequence
                            if(sequenceWithElementRemoved[k] > sequenceWithElementRemoved[k-1]) {
                                // do nothing, but get ready to return true if else is never entered
                            } else {
                                if(l<testsRequired-1) { 
                                    Console.WriteLine("first subcheck failed");
                                    testFailed=true;
                                    break;
                                } else {
                                    Console.WriteLine("!! returning false (from sub check)");
                                    return false;
                                }
                            }
                        }

                        // if a test has not failed, we are good to return
                        if (!testFailed) {
                            Console.WriteLine("subcheck passed, returning true");
                            return true;  
                        }
                    }  
                } else {
                    Console.WriteLine("!! Sequence off, remove unavailable, returning false");
                    // neither sequence was in order
                    return false;
                }

            }

            return true;
        }
    }
}
