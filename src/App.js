import React, { Component } from 'react';
import Todos from './components/Todos';

class  App extends Component {
  state = {
    todos: [
      {
      id: -1,
      title: "Work",
      completed: true
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

  render() {
    return (
      <div className="App">
        <Todos todos={this.state.todos} />
      </div>

    );

  }
  
}

export default App;
