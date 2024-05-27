package main

import (
    "fmt"
    "os"
    "time"
)

const (
    arraySize = 10000000 
    numArrays = 10       
    iterations = 1000    
)

func main() {
    pid := os.Getpid()
    fmt.Printf("Process ID: %d\n", pid)

    arrays := make([][]int, numArrays)

    for i := 0; i < numArrays; i++ {
        arrays[i] = make([]int, arraySize)
    }

    for iter := 0; iter < iterations; iter++ {
        if(iter % 100 == 0) {
			fmt.Printf("Iteration: %d\n", iter+1);
		}
        for i := 0; i < numArrays; i++ {
            for j := 0; j < arraySize; j++ {
                arrays[i][j] = j + arrays[i][j]%10
            }
        }
        time.Sleep(100 * time.Millisecond) 
    }
}
