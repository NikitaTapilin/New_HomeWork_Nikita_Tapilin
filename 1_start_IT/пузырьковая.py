list = [23, 3, 42, -10, 5]
size = list.lenght
index_first = 0
while index_first < size
	index_second = 0
	while index_second < size - 1
		if list[index_second] > list[index_second + 1]
			temp = list[index_second]
			list[index_second] = list [index_second + 1]
			list [index_second] = temp
		index_second ++
	index_first ++
print(list)