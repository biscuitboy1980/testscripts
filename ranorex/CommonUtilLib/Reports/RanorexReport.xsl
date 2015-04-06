<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="message">

    <!--<xsl:choose>
          <xsl:when test ="./Result/State = $TRUE">
          <xsl:variable name="Path" select="./General/TestcaseName"/>
            <td width="32%" bgcolor="#00FF00"><a href="{./General/TestcaseName/@href}"><xsl:value-of select ="./General/TestcaseName"/></a></td>
            <td width="68%" bgcolor="#00FF00"><xsl:value-of select ="./Result/State"/></td>
          </xsl:when>
          <xsl:otherwise >
            <td width="32%" bgcolor="#FF0000"><a href="{./General/TestcaseName/@href}"><xsl:value-of select ="./General/TestcaseName"/></a></td>
            <td width="68%" bgcolor="#FF0000"><xsl:value-of select ="./Result/State"/></td>
          </xsl:otherwise>
        </xsl:choose>
		-->
    <xsl:choose>
      <xsl:when test ="@level = 'WARN'">
        <tr class="warn {./@category}Warn">
          <td>
            <xsl:value-of select ="./@time"/>
          </td>
          <td>
            <xsl:value-of select ="./@level"/>
          </td>
          <td>
            <xsl:value-of select ="./@category"/>
          </td>
          <td>
            <xsl:copy-of select ="."/>
          </td>
        </tr>
      </xsl:when>
      <xsl:when test ="@level = 'ERROR'">
        <tr class="error {./@category}Error">
          <td>
            <xsl:value-of select ="./@time"/>
          </td>
          <td>
            <xsl:value-of select ="./@level"/>
          </td>
          <td>
            <xsl:value-of select ="./@category"/>
          </td>
          <td>
            <xsl:copy-of select ="."/>
          </td>
        </tr>
      </xsl:when>
      <xsl:when test ="@level = 'DEBUG'">
        <tr class="debug">
          <td>
            <xsl:value-of select ="./@time"/>
          </td>
          <td>
            <xsl:value-of select ="./@level"/>
          </td>
          <td>
            <xsl:value-of select ="./@category"/>
          </td>
          <td>
            <xsl:copy-of select ="."/>
          </td>
        </tr>
      </xsl:when>
      <xsl:when test ="@level = 'SUCCESS'">
        <tr class="success">
          <td>
            <xsl:value-of select ="./@time"/>
          </td>
          <td>
            <xsl:value-of select ="./@level"/>
          </td>
          <td>
            <xsl:value-of select ="./@category"/>
          </td>
          <td>
            <xsl:copy-of select ="."/>
          </td>
        </tr>
      </xsl:when
		>
      <xsl:when test ="@level = 'FAILURE'">
        <tr class="failure">
          <td>
            <xsl:value-of select ="./@time"/>
          </td>
          <td>
            <xsl:value-of select ="./@level"/>
          </td>
          <td>
            <xsl:value-of select ="./@category"/>
          </td>
          <td>
            <xsl:copy-of select ="."/>
          </td>
        </tr>
      </xsl:when>
      <xsl:when test ="@level = 'Info'">
        <tr class="info {./@category}Info">
          <td>
            <xsl:value-of select ="./@time"/>
          </td>
          <td>
            <xsl:value-of select ="./@level"/>
          </td>
          <td>
            <xsl:value-of select ="./@category"/>
          </td>
          <td>
            <xsl:copy-of select ="."/>
          </td>
        </tr>
      </xsl:when>
      <xsl:otherwise>
        <tr class="info {./@category}Info">
          <td>
            <xsl:value-of select ="./@time"/>
          </td>
          <td>
            <xsl:value-of select ="./@level"/>
          </td>
          <td>
            <xsl:value-of select ="./@category"/>
          </td>
          <td>
            <xsl:copy-of select ="."/>
          </td>
        </tr>
      </xsl:otherwise>
    </xsl:choose>

  </xsl:template>

  <xsl:template match="/log">
    <html>
      <head>
        <title>
          <xsl:value-of select ="/log/@title"/>
        </title>
        
         <style type="text/css">
    	
    	html,body 
    	{ 
    	color: black;
    	background: #ebebeb url(../Images/page-bg.png) repeat-x;
		font-size: 1em;
    	font-family: Verdana;
    	margin: 0;
    	padding: 0;
    	text-align:center; 
    	} 
    	
    	a:link 
    	{ 
    	color: #c11111; 
    	} 
    	
    	a:visited 
    	{ 
    	color: #db4848;
    	}
    	
		a:active 
    	{ 
    	color: #c11111; 
    	} 
    	
    	a:hover
    	{ 
    	color: black; 
    	} 
    	
    	body, html, div, p, i, strong, table 
    	{
    	color:#606060; 
    	} 
    	
    	img{border:0px;} div#Content img 
    	{
		margin: 7px 0;
    	} 
    	
    	p,i 
    	{ 
    	margin: 0; 
    	padding: 3px 0px; 
    	} 
    	
    	del 
    	{ 
    	color:#c11111;
    	} 
    	
    	div#Content table 
    	{ 
    	font-size: 1em;
    	margin: 2px;
    	} 
    	
    	table td 
    	{
		padding: 3px 4px;
    	margin: 0;
    	} 
    	
    	#simpletable td 
    	{ 
    	padding: 5px; 
    	}
    	
    	
		.comparison 
    	{
    	/*border: 1px solid #d0d0d0;
    	*/ margin: 10px 0pt 40px 10px;
    	}
    	
    	.comparison td 
    	{ 
    	padding: 5px 9px;
    	text-align: center;
		border-right: 1px solid #eee;
    	}
    	
    	.comparison .cat 
    	{ 
    	border-bottom: 1px solid #dfdfdf;
    	}
    	
    	.comparison td p 
    	{
    	text-align: right;
    	color: #333;
    	}
    	
		.comparison .odd
    	{ 
    	background-color: #f4f4f4;
    	}
    	
    	.comparison .even
    	{
    	} 
    	
    	h1, h2, h3, h4, h5, h6 
    	{ 
    	font-family: Verdana, Arial;
    	font-weight: normal;
		padding:0;
    	letter-spacing: -1px;
    	}
    	
    	h1 
    	{ 
    	font-size: 19pt; 
    	font-weight: 100;
    	color: #d00000;
    	margin: 0 0 15px 0;
    	} 
    	
    	h1 em 
    	{ 
    	display: none; 
    	} 
    	
    	h2 
    	{
		font-size: 14pt;
    	color: #444;
    	margin: 20px 0 6px 0;
    	}
    	
    	h3 
    	{ 
    	font-size: 10pt;
    	color: #555;
    	margin: 18px 0 6px 0;
    	font-weight: bold;
    	}
    	
    	h4 
    	{
		font-size: 10pt;
    	color: #888;
    	margin: 15px 0 4px 0;
    	font-weight: bold;
    	}
    	
		abbr, acronym 
    	{ 
    	border-bottom: 1px dotted #888;
    	cursor:help; 
    	}
    	
    	#Content #Top 
    	{ 
    	margin-bottom: 10px;
    	width: 590px;
    	height: 150px;
    	} 
    	
    	#Content #Top
		h1 
    	{ 
    	text-align: right;
    	border: 0;
    	color: #c00;
    	margin:0;
    	padding: 5px;
    	} 
    	
    	#Content #Top img 
    	{ 
    	position: absolute;
    	z-index: 1;
    	}
    	
    	div#Content ulli 
    	{ 
    	padding: 2px 0;
    	} 
    	
    	div#page 
    	{ text-align: left;
    	margin: 0 auto ;
		width: 850px;
    	padding: 20px 0 0 0 ;
    	}
    	
    	#Header 
    	{ 
    	padding: 0; text-align: center;
    	vertical-align:bottom;
    	background: url(../Images/bg.png) repeat-y;
    	}
    	
		#header-top 
    	{ margin-left: 25px;
    	height:65px;
    	width:800px;
    	display:block;
    	background: url(../Images/logo.png) no-repeat 0px 0px;
    	border-bottom:2px solid #00246B;
    	}
    	
    	#header-top #logo 
    	{ 
    	margin:0;
    	padding: 0;
    	}
    	
		#header-top #logo a 
    	{ 
    	margin: 10 0 15 0px;
    	width: 800px;
    	height: 65px;
		display:block;
    	
    	}
    	
    	#header-top #logo
		em {display:none;} 
    	
    	#header-top #small-nav 
    	{ 
    	float:right; 
    	font-size: 8pt;
		margin: 10px 17px 0 0 ;
    	color: #aaa;
    	}
    	
    	#top-nav 
    	{ 
    	background: url(../Images/nav-bg.png) repeat-x; margin: 0 25px;
    	}
    	
    	#top-nav #crumbs-menu 
    	{
		float:left;
    	}
    	
    	#top-nav #top-menu 
    	{ 
    	float:right;
    	} 
    	
    	#top-nav-bottom 
    	{
		clear:both;
    	font-size:1px;
    	height:0;
    	padding:0;
    	margin:0;
    	}
    	
		#header-bottom 
    	{ 
    	font-size: 1pt;
    	height: 13px;
    	background: url(../Images/header-bottom.png) repeat-y;
    	}
    	
    	#container 
    	{ 
    	background: url(../Images/bg.png) repeat-y;
    	padding-top: 15px;
    	}
    	
    	div#Content 
    	{ 
    	float: right;
    	font-size: 0.7em;
    	background-color: #fff;
    	margin: 0 40px 30px 0;
    	padding: 0 10px 0 15px;
    	width: 565px;
    	}
    	
    	* html div#Content 
    	{ 
    	height: 1em; /* Workaround gegen den 3-Pixel-Bug des Internet Explorers */ margin: 0 20px 0 0;
    	padding:0;
    	}
    	
    	#LeftBar 
    	{ 
    	float: left;
    	font-size: 8pt;
    	width: 180px;
		padding: 0 0 0 25px;
    	margin: 0 0 0 0px;
    	}
    	
    	#LeftBar h2 
    	{ 
    	font-size: 10pt;
		font-weight: bold;
    	color: #444;
    	margin: 0 15px 10px 0px;
    	}
    	
    	#LeftBar .content 
    	{ 
    	padding: 20px 15px 20px 15px;
    	}
    	
    	#Footer 
    	{ 
    	font-size: 7pt;
		margin:0;
    	padding: 20px 0 10px 0px;
    	text-align: center;
    	color: #888;
		background: #ebebeb url(../Images/footer.png) top no-repeat;
    	}
    	
    	#Footer a:link, #Footer a:hover, #Footer a:visited, #Footer a:active 
    	{ 
    	color: #888;
    	}
    	
		#Footer a:hover 
    	{ 
    	color: black;
    	} 
    	
    	html,body 
    	{ 
    	color: black;
		background-color: #ebebeb;
    	font-size: 1em;
    	font-family: Verdana;
    	margin: 0;
    	padding: 0;
    	text-align: center;
    	}
    	
    	body, html, div, p, i, strong, table 
    	{
    	color:#606060;
    	} 
    	
    	img
    	{
    	border:0px;
    	} 
    	
    	div#Content img 
    	{ 
    	margin: 7px 0;
    	}
    	
    	p,i 
    	{ 
    	margin: 0;
    	padding: 3px 0px;
    	}
    	
    	div#Content table 
    	{ 
    	font-size: 1em;
    	margin: 2px;
    	}
    	
    	table td 
    	{ 
    	padding: 3px 4px;
    	margin: 0;
    	}
    	
    	a:link 
    	{
		color: #c11111;
    	}
    	
    	a:visited 
    	{ 
    	color: #db4848;
    	}
    	
    	a:active 
    	{ 
    	color: #c11111;
    	}
    	
    	a:hover 
    	{ 
    	color: black;
    	}
    	
    	div#page 
    	{ 
    	text-align: left;
		margin: 0 auto ;
    	width: 850px;
    	padding: 20px 0 0 0 ;
    	}
    	
    	div#Content 
    	{
		float: none;
    	font-size: 0.7em;
    	background-color: #fff;
    	margin: 0 35px 30px 35px;
    	padding: 0;
    	width: auto;
    	}
    	
    	* html div#Content 
    	{ 
    	height: 1em;
    	margin: 0 35px 30px 35px;
    	padding:0;
    	}
    	
    	h1 
    	{ 
    	font-size: 13pt;
    	}
    	
    	th 
    	{
		background-color: #eee;
    	text-align: left;
    	padding: 10px 4px;
    	}
    	
    	td 
    	{
		border-bottom: 1px solid #eee; 
    	padding: 0;
    	}
    	
    	.debug 
    	{ 
    	color: gray;
    	}
    	
		.invisible 
    	{ 
    	display:none;
    	}
    	
    	.warn 
    	{ 
    	color: #EFB54A;
    	font-weight: bold;
		}
    	
    	.error 
    	{ color: red;
    	font-weight: bold;
    	}
    	
    	.failure 
    	{ 
    	color: #fff;
		background-color: #d80000;
    	font-weight: bold;
    	}
    	
    	.success 
    	{ 
    	color: #fff;
		background-color: green;
    	font-weight: bold;
    	}
    	
    	fieldset 
    	{ 
    	clear: both;
		font-size: 100%;
    	border-color: #000000;
    	border-width: 0;
    	border-style: solid none none none;
    	padding: 5px;
    	margin: 3px 2px 10px 2px;
    	} 
    	
    	fieldset legend 
    	{ 
    	font-size: 10pt;
    	color: #555;
    	font-weight: bold;
    	margin: 0 0 0 -7px;
    	padding: 10px 0 0 0;
    	}
    	
    	label 
    	{ 
    	float: left;
    	text-align: right;
		width: auto;
    	margin-right: 0em;
    	padding: 2px 0;
    	}
    	
    	input 
    	{ 
    	float: left;
		margin-right: 30px;
    	}

</style> 

        <script type="text/javascript">
          <![CDATA[ 
			function switchVisibility(firstclassName, excludeClassname)
			{
				var tr = document.getElementsByTagName('tr');
				for(var i=0;i<tr.length;i++)
				{
					if(tr[i].className.search(firstclassName + ' invisible')>=0 && (tr[i].className.search(excludeClassname)<0 || excludeClassname=="")) 
						tr[i].className = tr[i].className.replace(firstclassName + ' invisible', firstclassName);
					else if(tr[i].className.search(firstclassName)>=0 && (tr[i].className.search(excludeClassname)<0 || excludeClassname==""))
					  	tr[i].className = tr[i].className.replace(firstclassName, firstclassName + ' invisible');
				}
			}
			 ]]>
        </script>

      </head>
      <body>
        <div id="page">
          <div id="header-top">
            <h1 id="logo">
              <a href="#" title="Ultra Electronics Advanced Tacitcal Systems">
                <em>UltraATS</em>
              </a>
            </h1>
            <div id="small-nav"></div>
          </div>

          <div id="container">
            <div id="Content">
              <h1>
                <xsl:value-of select ="/log/@title"/>
              </h1>
              <fieldset>
                <legend>Log Level</legend>
                <label for="debug">Debug</label>
                <input type="checkbox" id="debug" name="debug" onClick="switchVisibility('debug','Validation');" checked="1" />
                <label for="info">Info</label>
                <input type="checkbox" id="info" name="info" onClick="switchVisibility('info','Validation');" checked="1" />
                <label for="warn">Warn</label>
                <input type="checkbox" id="warn" name="warn" onClick="switchVisibility('warn','Validation');" checked="1" />
                <label for="error">Error</label>
                <input type="checkbox" id="error" name="error" onClick="switchVisibility('error','Validation');" checked="1" />

                <label for="testresult">Test Result</label>
                <input type="checkbox" id="testresult" name="testresult" onClick="switchVisibility('failure','success');switchVisibility('success','failure')" checked="1" />

              </fieldset>
              <table border="0" cellspacing="0" width="100%">
                <tr>
                  <th width="15%" >
                    <b>Time</b>
                  </th>
                  <th width="10%" >
                    <b>Level</b>
                  </th>
                  <th width="15%" >
                    <b>Category</b>
                  </th>
                  <th>
                    <b>Message</b>
                  </th>
                </tr>
                <xsl:apply-templates select="//message"/>
              </table>

            </div>
            <div style="clear:both"></div>
            <div id="Footer"></div>
          </div>
        </div>
      </body>
    </html>
  </xsl:template>

  <!--
  Template zum Einfuegen von Linefeeds:
  Alle in der Description angegebenen "<lf/>" TAGS werden in "<br/>" TAGS umgewandelt.
  -->
  <xsl:template match="lf">
    <br/>
  </xsl:template>

</xsl:stylesheet>

