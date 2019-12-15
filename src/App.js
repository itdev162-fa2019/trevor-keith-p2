import React, { Component } from 'react';
import Header from './components/layout/header';
import Todos from './components/Todos';
import AddTodo from './components/AddTodo';
import uuid from 'uuid';

class  App extends Component {
  state = {
    todos: [
      {
      id: uuid.v4(),
      title: "Work",
      completed: false
      },
      {
        id: uuid.v4(),
        title: "Make dinner",
        completed: false
      },
      {
        id: uuid.v4(),
        title: "Eat dinner",
        completed: false
      }

    ]

  }

  // Toggle Complete
  toggleComplete = (id) => {
    this.setState({ todos: this.state.todos.map(todo => {
      if(todo.id === id) {
        todo.completed = !todo.completed;

      }

      return todo;

    }) })
    
  }

  // Delete todo
  delTodo = (id) => {
    this.setState({todos: [...this.state.todos.filter(todo => todo.id !== id)] })

  }

  // Add Todo
  addTodo = (title) => {
    if(title) {
      const newTodo = {
        id: uuid.v4(),
        title,
        completed: false

      }

      this.setState({ todos: [...this.state.todos, newTodo] })
    }

  }

  render() {
    return (
      <div className="App">
        <div className="container">
          <Header />
          <AddTodo addTodo={this.addTodo} />
          <Todos todos={this.state.todos} toggleComplete={this.toggleComplete} delTodo={this.delTodo} />

        </div>

      </div>

    );

  }
  
}

export default App;
