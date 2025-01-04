# F# Mutable Variable Shadowing in Swap Function

This example demonstrates a common error in F# related to mutable variables and shadowing within functions.  The `swap` function attempts to swap the values of two mutable variables, but due to the way variables are scoped, it doesn't work as intended.

The `bug.fs` file contains the code with the error.  The `bugSolution.fs` file provides a corrected version.

## Problem

The issue is that the `x` and `y` variables inside the `swap` function are *shadowing* the `x` and `y` variables in the outer scope.  The swap modifies the *local* variables, leaving the original variables unchanged. 

## Solution

The solution involves passing the mutable variables as reference parameters (using `byref`).  This allows the `swap` function to directly modify the original variables.