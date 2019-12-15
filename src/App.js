import React, { Component } from 'react';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import Header from './components/layout/header';
import Todos from './components/Todos';
import AddTodo from './components/AddTodo';
import About from './components/pages/about';
//import uuid from 'uuid';
import axios from 'axios';

class  App extends Component {
  state = {
    todos: []

  }

  componentDidMount() {
    axios.get('https://jsonplaceholder.typicode.com/todos?_limit=10')
      .then(res => {
        this.setState({ todos: res.data });

      });

    // var
    //   numZero = 0,
    //   stringZero = "0",
    //   arrayZero = [];

    // console.log(`
    //   ${numZero}   == "${stringZero}":\t ${numZero === stringZero}
    //   ${numZero}   == [${arrayZero}]:\t ${numZero === arrayZero}
    //   "${stringZero}" == [${arrayZero}]:\t ${stringZero === arrayZero}

    //   People use this language unironically BTW

    // `);



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
    axios.delete(`https://jsonplaceholder.typicode.com/todos/${id}`)
      .then(res => this.setState({ todos: [...this.state.todos.filter(todo => todo.id !== id)] }));

  }

  // Add Todo
  addTodo = (title) => {
    if(title) {
      axios.post('https://jsonplaceholder.typicode.com/todos', {
          title,
          completed: false

        })
        .then(res => this.setState({
          todos: [...this.state.todos, res.data]

        }))

    }

  }

  render() {
    return (
      <Router>
        <div className="App">
          <div className="container">
            <Header />
            <Route exact path="/" render={props => (
                <React.Fragment>
                  <AddTodo addTodo={this.addTodo} />
                  <Todos todos={this.state.todos} toggleComplete={this.toggleComplete} delTodo={this.delTodo} />

                </React.Fragment>

              )}>

            </Route>
            <Route path="/about" component={About} />

          </div>

        </div>

      </Router>

    );

  }
  
}

export default App;
