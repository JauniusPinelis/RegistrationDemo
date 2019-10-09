import React, { Component } from "react";
//React bootstrap
import Form from "react-bootstrap/Form";
import Row from "react-bootstrap/Row";
import Col from "react-bootstrap/Col";

export default class Question extends Component {
  render() {
    let question = this.props.question;
    let options = [];
    options.push(<option name={question.name} key="0" value=""></option>) 
    for (const option of question.dropdown.selectFields) {
      options.push(<option name={question.name} value={option.id} key={option.id}>{option.name}</option>);
    } 
    return (
      <Form.Group as={Row} controlId={question.id}>
        <Form.Label column sm="2">
          {question.name}
        </Form.Label>
        <Col sm="10">
          <Form.Control name={question.name} disabled={this.props.disabled} 
          onChange={this.props.handleChange} as="select" value={question.value ? question.value : '' }>{options}</Form.Control>
        </Col>
      </Form.Group>
    );
  }
}
