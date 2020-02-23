import React from 'react';
import { Col, Grid, Row } from 'react-bootstrap';
import NavMenu from './NavMenu';
import TitleView from './TitleView';

export default props => (
  <Grid fluid>
    <Row>
      <Col sm={4}>
        <NavMenu />
      </Col>
      <Col sm={8}>
<TitleView/>

      </Col>
    </Row>
  </Grid>
);
