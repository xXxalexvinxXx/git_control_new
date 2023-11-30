Public Sub fizzbuzz()
	For n = 1 To 100
	Select Case 0
		Case n Mod 15
		f = "FizzBuzz"
		Case n Mod 3
		f = "Fizz"
		Case n Mod 5
		f = "Buzz"
		Case Else
		f = n
	End Select
	Debug.Print f
	Next n
 End Sub
