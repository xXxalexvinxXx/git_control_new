	for i in range(0,101):
	if i % 3 == 0 and not i % 5 == 0:
		print "fizz: %d" % i
	elif i % 5 == 0 and not i % 3 == 0:
		print "buzz: %d" % i
	elif i % 3 == 0 and i % 5 == 0:
		print "FIZZBUZZ: %d" % i
	else:
		print i

python -c "print '\n'.join(['Fizz'*(x % 3 == 2) + 'Buzz'*(x % 5 == 4) or str(x + 1) for x in range(100)])"


	for i in xrange(0,101):
		s = ""
		if i % 3 == 0: s += "Fizz"
		if i % 5 == 0: s += "Buzz"
		print s if len(s) else i

