# Definition of the Node
class Node:
    def __init__(self, data):
        self.data = data
        self.prev = None
        self.next = None

# Function for creating the linked list
def create_doubly_linked_list(input_array):
    head = None
    for item in input_array:
        new_node = Node(item)
        if head is None:
            head = new_node
        else:
            current_node = head
            while current_node.next is not None:
                current_node = current_node.next
            current_node.next = new_node
            new_node.prev = current_node
    return head

# Function to sort the doubly linked list in descending order
def sort_doubly_linked_list_descending(head):
    if head is None:
        print("Error: The list is empty.")
        return
    
    swapped = True
    while swapped:
        swapped = False
        current_node = head
        while current_node.next is not None:
            if current_node.data < current_node.next.data:
                # Swap the data of the two nodes
                current_node.data, current_node.next.data = current_node.next.data, current_node.data
                swapped = True
            current_node = current_node.next

# Function to display the doubly linked list
def display_doubly_linked_list(head):
    if head is None:
        print("Error: The list is empty.")
        return
    
    current_node = head
    while current_node is not None:
        print(current_node.data, end="")
        if current_node.next is not None:
            print(" - ", end="")
        current_node = current_node.next
    print()

# Main function
def main():
    input_array = input("Input 12 strings: ").split(", ")

    # Creation of Doubly Linked List
    head = create_doubly_linked_list(input_array)
    
    # Sorting of the List
    sort_doubly_linked_list_descending(head)
    
    # Displaying the list
    print("\nOutput of sorted List:")
    display_doubly_linked_list(head)

# Calling of the main function
if __name__ == "__main__":
    main()