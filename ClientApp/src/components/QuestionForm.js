import React, { Component } from 'react'
import Question from "./Question";

export default class QuestionForm extends Component {
    render() {
        let questions = [];
        for (const question of this.props.questionData) {
            questions.push(<Question 
                handleChange={this.props.handleChange} 
                disabled={this.props.disabled} key={question.id} question={question} />);
        }
        return (
            <div>
                {questions}
            </div>
        )
    }
}
