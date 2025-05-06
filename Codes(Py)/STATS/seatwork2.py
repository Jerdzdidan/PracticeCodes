numbers = input("Enter a set of numbers: ").split(",")

numbers = [int(num) for num in numbers]
sorted_numbers = sorted(numbers)
print("Sorted list:", sorted_numbers)

sum_numbers = sum(sorted_numbers)
mean = sum_numbers / len(sorted_numbers)

def calculate_mode(nums):
    frequency = {}
    for num in nums:
        if num in frequency:
            frequency[num] += 1
        else:
            frequency[num] = 1
    
    max_frequency = max(frequency.values())

    mode = [num for num, freq in frequency.items() if freq == max_frequency]
    
    if len(mode) == len(frequency):
        return "No mode"
    
    return mode

def calculate_median(nums):
    n = len(nums)
    if n % 2 == 0:  
        median = (nums[n//2 - 1] + nums[n//2]) / 2
    else:  
        median = nums[n//2]
    return median

range_value = max(sorted_numbers) - min(sorted_numbers)

median = calculate_median(sorted_numbers)
mode = calculate_mode(sorted_numbers)

print(f"\nMean: {mean:.2f}")
print("Median:", median)
print("Mode:", mode)
print("Range:", range_value)