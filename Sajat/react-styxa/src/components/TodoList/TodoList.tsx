import { useEffect, useState } from "react";
import TextField from "../TextField/TextField";
import Button from "../Button/Button";

interface TodoItem {
  id: number;
  label: string;
  checked: boolean;
}

const TodoList = () => {
  const [todos, setTodos] = useState<TodoItem[]>([]);
  const [text, setText] = useState<string>("");

  const handleAddClick = () => {
    const insertedTodos = [
      ...todos,
      {
        id: Math.random(),
        label: text,
        checked: false,
      },
    ];

    setTodos(insertedTodos);
  };

  const handleRemoveClick = (id: number) => {
    const filteredTodos = todos.filter((todo) => todo.id !== id);

    setTodos(filteredTodos);
  };

  const handleTodoCheck = (id: number) => {
    const updatedTodos = todos.map((todoItem) => {
      if (todoItem.id === id) {
        return { ...todoItem, checked: !todoItem.checked }; //updated todo item
      }

      return todoItem; //not updated item
    });

    setTodos(updatedTodos);
  };

  useEffect(() => {
    //backend call
  }, [todos]);

  useEffect(() => {
    // console.log("mount");
    //backend call
  }, []);

  return (
    <div>
      <TextField label="Todo" onChange={setText} />
      <Button onClick={handleAddClick}>Add todo</Button>
      <ul>
        {todos.map((item, index) => {
          return (
            <li key={index}>
              <input
                type="checkbox"
                onChange={() => handleTodoCheck(item.id)}
              />
              <span>{item.label}</span>
              <Button onClick={() => handleRemoveClick(item.id)}>X</Button>
            </li>
          );
        })}
      </ul>
    </div>
  );
};

export default TodoList;
