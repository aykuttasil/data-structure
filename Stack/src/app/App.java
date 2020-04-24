package app;

public class App {
    public static void main(final String[] args) throws Exception {     
        /*   
        final Stack<Integer> s = new Stack<Integer>();
        s.push(1);
        s.push(2);
        s.add(3);

        System.out.println("Pop:" + s.pop());
        System.out.println("Peek:" + s.peek());
        */


        MyStack<Integer> myStack = new MyStack<Integer>();
        myStack.push(1);
        myStack.push(2);
        myStack.pop();
        myStack.push(3);
        myStack.push(4);

        System.out.println("----------");
        System.out.println("Peek:" + myStack.peek());
        myStack.pop();
        System.out.println("Peek:" + myStack.peek());
        System.out.println("Peek:" + myStack.peek());
        
    }
           
}

class Node<T>{
    T value;
    Node<T> next;
}

class MyStack<T> {    
    
    private Node<T> root;
    
    public void push(T item){                        
        Node<T> newNode = new Node<T>();
        newNode.value = item;

        if(root == null){
            root = newNode;
            return;
        }
    
        Node<T> temp = root;
        root = newNode;
        root.next = temp;

        System.out.println("newNode added:" + item);
    }

    public T peek(){
        return root.value;
    }

    public T pop(){
        T result = root.value;
        root = root.next;
        return result;
    }

}