import React, { Component } from 'react';
import Header from './components/layout/header';
import Todos from './components/Todos';
import AddTodo from './components/AddTodo';

class  App extends Component {
  state = {
    todos: [
      {
      id: -1,
      title: "Work",
      completed: false
      },
      {
        id: -2,
        title: "Make dinner",
        completed: false
      },
      {
        id: -3,
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

  render() {
    return (
      <div className="App">
        <div className="container">
          <Header />
          <AddTodo />
          <Todos todos={this.state.todos} toggleComplete={this.toggleComplete} delTodo={this.delTodo} />

        </div>
        
      </div>

    );

  }
  
}

export default App;
